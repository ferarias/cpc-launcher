using System;
using System.Collections;
using System.IO;

public class ListaFicherosCPC
{
	private string rutaDSK = "emulador/disc/";

	private ArrayList datos;

	public ListaFicherosCPC()
	{
		datos = new ArrayList();
	}

	public void Leer()
	{
		datos.Clear();
		try
		{
			string[] files = Directory.GetFiles(rutaDSK);
			string[] array = files;
			foreach (string text in array)
			{
				string text2 = text.Substring(checked(text.Length - 3)).ToLower();
				if (text2 == "dsk")
				{
					datos.Add(procesar(text, "Disco"));
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void Mostrar()
	{
		foreach (string dato in datos)
		{
			Console.WriteLine(dato);
		}
	}

	public int LeerCantidad()
	{
		return datos.Count;
	}

	public string LeerDato(int i)
	{
		return (string)datos[i];
	}

	private string procesar(string nombre, string tipo)
	{
		string text = nombre;
		checked
		{
			text = text.Substring(0, text.Length - 4);
			int num = text.LastIndexOf("/");
			text = text.Substring(num + 1);
			return text + "¬" + nombre + "¬" + tipo;
		}
	}

	public void Lanzar(string orden)
	{
	}
}
