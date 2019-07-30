using System;
using System.Collections.Generic;

namespace Test
{
	class main
	{
		public static void Main(string[] args)
		{
			Dengen d;

			d = new AcAdapter();
			int denatsu = d.kyuuden();
			Console.WriteLine(denatsu + "Vで給電されています");
			Console.ReadLine();
		}
	}

	interface Dengen
	{
		int kyuuden();
	}

	class JapaneseConsent
	{
		public int power()
		{
			return 100;
		}
	}

	class AcAdapter : Dengen
	{
		JapaneseConsent jc = new JapaneseConsent();
		public int kyuuden()
		{
			return (int)(jc.power() * 0.16);
		}
	}
}
