using System;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
public class Service : IService
{
	public int WebAdd(int x, int y)
	{
		return x + y;
	}
	public int WebSoustraction(int x, int y)
	{
		return x - y;
		
	}
	public int WebMultiply(int x, int y)
	{
		return x * y;
	}
	public int WebDivision(int x, int y)
	{
		return x / y;
	}
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
