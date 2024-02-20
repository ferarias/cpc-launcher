using System;
using System.Collections;
using System.IO;

public class ListaDescripcionesCPC
{
	private ArrayList datos;

	public ListaDescripcionesCPC()
	{
		datos = new ArrayList();
	}

	public void Leer()
	{
		datos.Clear();
		string path = "descripciones.txt";
		if (!File.Exists(path))
		{
			return;
		}
		StreamReader streamReader = File.OpenText(path);
		string text;
		do
		{
			text = streamReader.ReadLine();
			if (text != null)
			{
				datos.Add(text);
			}
		}
		while (text != null);
		streamReader.Close();
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

	public string LeerTeclas(string nombre)
	{
		string result = "Teclas: ";
		foreach (string dato in datos)
		{
			if (dato.ToUpper().IndexOf("\"" + nombre.ToUpper() + "\"") == 0)
			{
				int num = dato.LastIndexOf("\",\"");
				result = checked(dato.Substring(num + 3, dato.Length - num - 4));
			}
		}
		return result;
	}
}
