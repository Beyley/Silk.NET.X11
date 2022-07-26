using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.X11;
using TerraFX.Interop.Xlib;
using Window = Silk.NET.Windowing.Window;

X11Platform.GetOrRegister();

WindowOptions options = WindowOptions.Default;
// options.API = GraphicsAPI.Default

options.Size = new Vector2D<int>(800, 600);

X11Window window = (X11Window)Window.Create(options);

string vtx = @"#version 330 core
layout (location = 0) in vec3 aPos;
 
void main()
{
    gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);
}";

string frg = @"#version 330 core
out vec4 FragColor;

void main()
{
    FragColor = vec4(1.0f, 0.0f, 0.0f, 1.0f);
}";

GL gl = null!;

uint vtxShader;
uint frgShader;

uint program = 0;

uint vbo = 0;
uint vao = 0;

float[] vertices = {
	-0.5f, -0.5f, 0.0f,
	0.5f, -0.5f, 0.0f,
	0.0f,  0.5f, 0.0f
};

window.Load += () => {
	unsafe {
		Console.WriteLine($"Window loading!");

		gl = window.CreateOpenGL();

		vtxShader = gl.CreateShader(ShaderType.VertexShader);
		frgShader = gl.CreateShader(ShaderType.FragmentShader);
	
		gl.ShaderSource(vtxShader, vtx);
		gl.CompileShader(vtxShader);
		gl.ShaderSource(frgShader, frg);
		gl.CompileShader(frgShader);

		program = gl.CreateProgram();
	
		gl.AttachShader(program, vtxShader);
		gl.AttachShader(program, frgShader);
	
		gl.LinkProgram(program);
	
		gl.DeleteShader(vtxShader);
		gl.DeleteShader(frgShader);
	
		vbo = gl.GenBuffer();
 
		vao = gl.GenVertexArray();
		gl.BindVertexArray(vao);
		gl.BindBuffer(GLEnum.ArrayBuffer, vbo);
		gl.BufferData<float>(GLEnum.ArrayBuffer, vertices, GLEnum.StaticDraw);
		gl.VertexAttribPointer(0, 3, GLEnum.Float, false, 3 * sizeof(float), (void*)0);
		gl.EnableVertexAttribArray(0);
	}
};
window.Closing += () => {
	Console.WriteLine("Window Closing");
};

window.Resize += vector2D => {
	gl.Viewport(vector2D);
};

double delta = 0;
window.Render += d => {
	// Console.WriteLine($"fps: {1 / d}");
	
	delta += d;
	
	gl.ClearColor((float)((delta * 3) % 1d), (float)(delta % 1d), (float)((delta * 2) % 1d), 0);
	gl.Clear(ClearBufferMask.ColorBufferBit);
	
	gl.UseProgram(program);
	gl.BindVertexArray(vbo);
	gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
	
	unsafe {
		// int  length = "Test Draw!".Length;
		
		// Xlib.XDrawString(window._display, new Drawable(window._window), Xlib.DefaultGC(window._display, Xlib.DefaultScreen(window._display)), 10, 10, (sbyte*)ptr, length);
	}
};
window.Update += d => {};

window.Run();
