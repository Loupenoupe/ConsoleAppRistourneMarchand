namespace ConsoleAppRistourneMarchand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le prix de l'artefact ? ");
            decimal prix = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Faites vous partis de la Guilde des Marchands ? (oui ou non)");
            string guilde = Console.ReadLine();
            if (guilde == "oui")
            {
                prix = prix * 0.8m;
            }
            else if (guilde == "non")
            {
                Console.WriteLine("Possedez vous un Sceau des Ombres ? (oui ou non)");
                string sceau = Console.ReadLine();
                if (sceau == "oui" && prix >= 100)
                {
                    prix = prix * 0.85m;
                }
                if (sceau == "oui" && prix < 100)
                {
                    prix = prix * 0.9m;
                }
            }
            else
            {
                Console.WriteLine("Saisie incorrecte ! ");
            }
            prix = Convert.ToInt32(prix);
            Console.WriteLine($"Le prix final est de : {prix} pieces d'or");


        }
    }
}
