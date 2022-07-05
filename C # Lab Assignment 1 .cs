using System;

public class Class1
{
	public Class1()
	{
		static void main(string[] args);
        {
			bool exit = fasle;
			whiile(!exit);
            {
				try
                {
					console.Writeline("  enter '+' for adition ");
					console.Writeline("  enter '-' for subtraction ");
					console.Writeline("  enter '*' for multiplication ");
					console.Writeline("  enter '/' for Division ");
					console.Writeline("  enter 'C' or 'c' for  Clear ");
					console.Writeline("  enter 'E' or 'e' for Exit ");


					char read = Convert.Tochar(conlose.ReadLine());

					if (read == '+') {
						console.Writeline("enter frist number ");
						double num1 = Convert.ToDouble(console.ReadLine());
						console.Writeline("enter second number ");
						double num2 = Convert.ToDouble(console.ReadLine());
						Console.Writeline( $ "Answer": { num1 + num2} );
					}
					else if (read == '-') {
						console.Writeline("enter frist number ");
						double num1 = Convert.ToDouble(concole.ReadLine());
						console.Writeline("enter second number ");
						double num2 = Convert.ToDouble(console.ReadLine());
						Console.Writeline( $ "Answer": { num1 - num2} );
					}
					else if  (read == '*') {
						console.Writeline("enter frist number ");
						double num1 = Convert.ToDouble(console.ReadLine());
						console.Writeline("enter second number ");
						double num2 = Convert.ToDouble(console.ReadLine());
						Console.Writeline( $ "Answer": { num1* num2} );
					}
					else if (read == '/') {
						console.Writeline("enter frist number ");
						double num1 = Convert.ToDouble(console.ReadLine());
						console.Writeline("enter second number ");
						double num2 = Convert.ToDouble(console.ReadLine());
						Console.Writeline( $ "Answer": { num1 / num2} );
					}

					else if ( read =='C' || read == 'c')
                    {
						Console.Clear();
                    }
					 else if ( read == 'E' || read == 'e')
                    {
						exit = true;
                    }

					else {
						Console.Writeline(" Invalid  entry");
				}

			}

                catch
				{
					Console.Writeline(" Invalid  entry");
				}
			}

	}
}
