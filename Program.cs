using System;
using System.Security.Policy;
using System.Globalization;
using System.Diagnostics;

class CAS
{
    public void Uniform()
    {
        while (true)
        {
            Console.WriteLine("\n\nWelcome to CICTE Uniform!");
            Console.Write("Enter Limit Order: ");
            int size;
            bool validSize = int.TryParse(Console.ReadLine(), out size);

            if (!validSize)
            {
                Console.WriteLine("Invalid Input number only! ");
                CAS bla = new CAS();
                bla.Uniform();
            }




            OrderList cas = new OrderList(size);
            Console.WriteLine("\nCAS Uniform List");
            string[] CASSuniform = { "1.) SUNN Uniform", "2.) Department T-shirt", "3.) Sports Jersey" };

            for (int i = 0; i < CASSuniform.Length; i++)
            {
                Console.WriteLine(CASSuniform[i]);
            }

            Console.Write("Enter your choice! ");
            int item;
            bool validInput = int.TryParse(Console.ReadLine(), out item);

            if (!validInput || item < 1 || item > 3)
            {
                Console.WriteLine("\nInvalid Input! Please select (1-5) only! ");
            }

            switch (item)
            {
                case 1:
                    cas.pushUniform("CAS: " + "SUNN Uniform\n");
                    string[] SUNNuniform = { "1.) Small", "2.) Medium", "3.) Large" };
                    foreach (string items in SUNNuniform)
                    {
                        Console.WriteLine(items);
                    }
                    Console.Write("Enter your size: ");
                    int Uniform_Size;
                    bool vInput = int.TryParse(Console.ReadLine(), out Uniform_Size);


                    if (!vInput || Uniform_Size < 1 || Uniform_Size > 3)
                    {
                        Console.WriteLine($"Invalid Input ({Uniform_Size}), Please input (1-3)! ");
                    }
                    switch (Uniform_Size)
                    {
                        case 1:
                            cas.pushSizes("Small\n");
                            break;
                        case 2:
                            cas.pushSizes("Medium\n");
                            break;
                        case 3:
                            cas.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int quantity = int.Parse(Console.ReadLine());

                    cas.pushQuantity(quantity);

                    Console.Write("Type 'order' to order and 'display' to display your order and 'back': ");
                    string decision = Console.ReadLine();

                    switch (decision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cas.DisplayQuantity();
                            Console.Write("\nType back to exit: ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\nback");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input!");
                            }

                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cas.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or back to exit: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("\nInvalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());

                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"\nThank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("\nExit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("Exit"); return;
                                    }
                                    break;
                                case "back": Console.WriteLine("\nback"); return;
                            }
                            break;

                        case "back": Console.WriteLine("\nback"); return;

                    }
                    break;

                case 2:
                    cas.pushUniform("CAS: " + "Department T-shirt\n");

                    Console.WriteLine("CFAS Department T-Shirt Sizes");
                    string[] DpartmentSize = { "1.) Small", "2.) Medium", "3.) Large" };

                    for (int i = 0; i < DpartmentSize.Length; i++)
                    {
                        Console.WriteLine(DpartmentSize[i]);
                    }

                    Console.Write("Enter your size: ");
                    int Department_Size;
                    bool DvInput = int.TryParse(Console.ReadLine(), out Department_Size);


                    if (!DvInput || Department_Size < 1 || Department_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Department_Size}), Please input (1-3)! ");
                    }
                    switch (Department_Size)
                    {
                        case 1:
                            cas.pushSizes("Small\n");
                            break;
                        case 2:
                            cas.pushSizes("Medium\n");
                            break;
                        case 3:
                            cas.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int Dquantity = int.Parse(Console.ReadLine());

                    cas.pushQuantity(Dquantity);

                    Console.Write("\nType 'order' to order and 'display' to display your order and 'back': ");
                    string Ddecision = Console.ReadLine();

                    switch (Ddecision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cas.DisplayQuantity();
                            Console.Write("\nType back: ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\nback");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input!");
                            }
                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cas.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or no to exit: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("\nInvalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("\nGcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());


                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"\nThank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("\nExit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;
                                    }
                                    break;


                                case "no": Console.WriteLine("\nExit"); return;
                            }

                            break;

                    }

                    break;

                case 3:
                    cas.pushUniform("CAS: " + "Sport Jersey\n");

                    Console.WriteLine("\nCAS Sport Jersey Sizes:");
                    string[] SportJersey = { "1.) Small", "2.) Medium", "3.) Large" };

                    for (int i = 0; i < SportJersey.Length; i++)
                    {
                        Console.WriteLine(SportJersey[i]);
                    }

                    Console.Write("Enter your size: ");
                    int Jersey_Size;
                    bool SvInput = int.TryParse(Console.ReadLine(), out Jersey_Size);


                    if (!SvInput || Jersey_Size < 1 || Jersey_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Jersey_Size}), Please input (1-3)! ");
                    }
                    switch (Jersey_Size)
                    {
                        case 1:
                            cas.pushSizes("Small\n");
                            break;
                        case 2:
                            cas.pushSizes("Medium\n");
                            break;
                        case 3:
                            cas.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int Squantity = int.Parse(Console.ReadLine());

                    cas.pushQuantity(Squantity);

                    Console.Write("Type 'order' to order and 'display' to display your ordera and 'back': ");
                    string Sdecision = Console.ReadLine();

                    switch (Sdecision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cas.DisplayQuantity();
                            Console.WriteLine("\nType 'back': ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\back");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Input");
                            }

                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cas.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or no to exit: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("\nInvalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());


                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"Thank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("Exit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;
                                    }
                                    break;

                                case "no": Console.WriteLine("\nExit"); break;

                            }

                            break;

                        case "back": Console.WriteLine("\nback"); return;

                    }

                    break;



            }
        }
    }
}
class CFAS
{
    public void Uniform()
    {
        while (true)
        {
            Console.WriteLine("\n\nWelcome to CFAS Uniform!");
            Console.Write("Enter Limit Order: ");
            int size;
            bool validSize = int.TryParse(Console.ReadLine(), out size);


            if (!validSize)
            {
                Console.WriteLine("\nInvalid Input number only! ");
                CFAS bla = new CFAS();
                bla.Uniform();
            }


            OrderList cfas = new OrderList(size);

            string[] CFASuniform = { "\n1.) SUNN Uniform", "2.) Department T-shirt", "3.) Sports Jersey" };
            Console.WriteLine("\nCFAS Uniform List");

            for (int i = 0; i < CFASuniform.Length; i++)
            {
                Console.WriteLine(CFASuniform[i]);
            }

            Console.Write("Enter your choice! ");
            int item;
            bool validInput = int.TryParse(Console.ReadLine(), out item);

            if (!validInput || item < 1 || item > 5)
            {
                Console.WriteLine("\nInvalid Input! Please select (1-5) only! ");
            }

            switch (item)
            {
                case 1:
                    cfas.pushUniform("CFAS " + "SUNN Uniform\n");

                    Console.WriteLine("\nCFAS Uniform Sizes List");
                    string[] SUNNuniform = { "1.) Small", "2.) Medium", "3.) Large" };

                    foreach (string items in SUNNuniform)
                    {
                        Console.WriteLine(items);
                    }

                    Console.Write("Enter your size: ");
                    int Uniform_Size;
                    bool vInput = int.TryParse(Console.ReadLine(), out Uniform_Size);


                    if (!vInput || Uniform_Size < 1 || Uniform_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Uniform_Size}), Please input (1-3)! ");
                    }
                    switch (Uniform_Size)
                    {
                        case 1:
                            cfas.pushSizes("Small\n");
                            break;
                        case 2:
                            cfas.pushSizes("Medium\n");
                            break;
                        case 3:
                            cfas.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int quantity = int.Parse(Console.ReadLine());


                    cfas.pushQuantity(quantity);

                    Console.Write("\nType 'order' to order and 'display' to display your order and 'back': ");
                    string decision = Console.ReadLine();

                    switch (decision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cfas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cfas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cfas.DisplayQuantity();
                            Console.Write("Tye back: ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\nback");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Input!");
                            }

                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cfas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cfas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cfas.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or no to exit: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("\nInvalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());

                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"Thank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("Exit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;
                                    }
                                    break;


                                case "no": Console.WriteLine("\nExit"); return;
                            }

                            break;

                        case "back": Console.WriteLine("\nback"); return;

                    }

                    break;

                case 2:
                    cfas.pushUniform("CFAS: " + "Department T-shirt\n");

                    Console.WriteLine("\nCFAS Department T-Shirt Sizes List");
                    string[] DpartmentSize = { "1.) Small", "2.) Medium", "3.) Large" };

                    for (int i = 0; i < DpartmentSize.Length; i++)
                    {
                        Console.WriteLine(DpartmentSize[i]);
                    }

                    Console.Write("Enter your size: ");
                    int Department_Size;
                    bool DvInput = int.TryParse(Console.ReadLine(), out Department_Size);


                    if (!DvInput || Department_Size < 1 || Department_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Department_Size}), Please input (1-3)! ");
                    }
                    switch (Department_Size)
                    {
                        case 1:
                            cfas.pushSizes("Small\n");
                            break;
                        case 2:
                            cfas.pushSizes("Medium\n");
                            break;
                        case 3:
                            cfas.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int Dquantity = int.Parse(Console.ReadLine());

                    cfas.pushQuantity(Dquantity);

                    Console.WriteLine("Type 'order' to order and 'display' to display your order and back: ");
                    string Ddecision = Console.ReadLine();

                    switch (Ddecision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cfas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cfas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cfas.DisplayQuantity();
                            Console.WriteLine("Type back: ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\back");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Input");
                            }

                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cfas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cfas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cfas.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or no to exit: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("Invalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());


                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"Thank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("Exit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;
                                    }
                                    break;

                                case "no": Console.WriteLine("\nExit"); return;

                            }

                            break;

                        case "back": Console.WriteLine("\nback"); return;

                    }

                    break;

                case 3:
                    cfas.pushUniform("CFAS: " + "Sport Jersey\n");

                    Console.WriteLine("\nCFAS Sport Jersey Sizes");
                    string[] SportJersey = { "1.) Small", "2.) Medium", "3.) Large" };

                    for (int i = 0; i < SportJersey.Length; i++)
                    {
                        Console.WriteLine(SportJersey[i]);
                    }

                    Console.Write("Enter your size: ");
                    int Jersey_Size;
                    bool SvInput = int.TryParse(Console.ReadLine(), out Jersey_Size);


                    if (!SvInput || Jersey_Size < 1 || Jersey_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Jersey_Size}), Please input (1-3)! ");
                    }
                    switch (Jersey_Size)
                    {
                        case 1:
                            cfas.pushSizes("Small\n");
                            break;
                        case 2:
                            cfas.pushSizes("Medium\n");
                            break;
                        case 3:
                            cfas.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int Squantity = int.Parse(Console.ReadLine());

                    cfas.pushQuantity(Squantity);

                    Console.Write("Type 'order' to order and 'display' to display your order and back: ");
                    string Sdecision = Console.ReadLine();

                    switch (Sdecision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cfas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cfas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cfas.DisplayQuantity();
                            Console.Write("Type back: ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\nback");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input!");
                            }

                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cfas.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cfas.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cfas.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or no to exit: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("Invalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());


                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"Thank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("Exit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;
                                    }
                                    break;

                                case "no": Console.WriteLine("\nback"); return;

                            }

                            break;

                        case "back": Console.WriteLine("\nback"); return;

                    }

                    break;



            }


        }


    }
}
class CICTE
{

    public void cicte()
    {
        while (true)
        {
            Console.WriteLine("\n\nWelcome to CICTE Uniform!");
            Console.Write("Enter Limit Order: ");

            int size;
            bool validSize = int.TryParse(Console.ReadLine(), out size);

            if (!validSize)
            {
                Console.WriteLine("\nInvalid Input number only!");
                CICTE bla = new CICTE();
                bla.cicte();
            }


            OrderList cicte = new OrderList(size);
            string[] CICTESuniform = { "1.) SUNN Uniform", "2.) Department T-shirt", "3.) Sports Jersey" };
            Console.WriteLine("\nCICTE Uniform List");

            for (int i = 0; i < CICTESuniform.Length; i++)
            {
                Console.WriteLine(CICTESuniform[i]);
            }

            Console.Write("Enter your choice! ");
            int item;
            bool validInput = int.TryParse(Console.ReadLine(), out item);

            if (!validInput || item < 1 || item > 3)
            {
                Console.WriteLine("\nInvalid Input! Please select (1-5) only! ");
            }

            switch (item)
            {
                case 1:
                    cicte.pushUniform("CICTE: " + "SUNN Uniform\n");
                    Console.WriteLine("\nCICTE Uniform Sizes");
                    string[] SUNNuniform = { "1.) Small", "2.) Medium", "3.) Large" };

                    Console.WriteLine("\nSize List");
                    foreach (string items in SUNNuniform)
                    {
                        Console.WriteLine(items);
                    }

                    Console.Write("Enter your size: ");
                    int Uniform_Size;
                    bool vInput = int.TryParse(Console.ReadLine(), out Uniform_Size);


                    if (!vInput || Uniform_Size < 1 || Uniform_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Uniform_Size}), Please input (1-3)! ");
                        return;
                    }
                    switch (Uniform_Size)
                    {
                        case 1:
                            cicte.pushSizes("Small\n");
                            break;
                        case 2:
                            cicte.pushSizes("Medium\n");
                            break;
                        case 3:
                            cicte.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("\nEnter the quantity of your order: ");
                    int quantity = int.Parse(Console.ReadLine());

                    cicte.pushQuantity(quantity);

                    Console.Write("\nType 'order' to order and 'display' to display your order and type 'back': ");
                    string decision = Console.ReadLine();

                    switch (decision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cicte.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cicte.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cicte.DisplayQuantity();
                            Console.Write("\nType 'back' to back: ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\nback");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Input!");
                            }

                            break;

                        case "order":
                            Console.WriteLine("\nList of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cicte.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cicte.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cicte.DisplayQuantity();
                            Console.Write("\nType 'yes' to proceed payment or 'back': ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("\nAvailable payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("\nInvalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("\nType your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());

                                            Console.Write("\nProceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"\nThank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("\nExit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;

                                    }
                                    break;

                                case "back": Console.WriteLine("\nBack"); return;

                            }
                            break;

                        case "back": Console.WriteLine("\nback"); return;

                    }
                    break;

                case 2:
                    cicte.pushUniform("CICTE: " + "Department T-shirt\n");
                    Console.WriteLine("\nCICTE Department T-Shirt Sizes");
                    string[] DpartmentSize = { "1.) Small", "2.) Medium", "3.) Large" };

                    for (int i = 0; i < DpartmentSize.Length; i++)
                    {
                        Console.WriteLine(DpartmentSize[i]);
                    }

                    Console.Write("Enter your size: ");
                    int Department_Size;
                    bool DvInput = int.TryParse(Console.ReadLine(), out Department_Size);


                    if (!DvInput || Department_Size < 1 || Department_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Department_Size}), Please input (1-3)! ");
                    }
                    switch (Department_Size)
                    {
                        case 1:
                            cicte.pushSizes("Small\n");
                            break;
                        case 2:
                            cicte.pushSizes("Medium\n");
                            break;
                        case 3:
                            cicte.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int Dquantity = int.Parse(Console.ReadLine());

                    cicte.pushQuantity(Dquantity);

                    Console.Write("Type 'order' to order and 'display' to display your order and 'back': ");
                    string Ddecision = Console.ReadLine();

                    switch (Ddecision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cicte.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cicte.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cicte.DisplayQuantity();
                            Console.Write("\ntype 'back': ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\nBack");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Input");
                            }

                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cicte.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cicte.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cicte.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or back: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("Invalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());


                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"Thank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("Exit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;
                                    }
                                    break;

                                case "back": Console.WriteLine("\nback"); return;


                            }
                            break;

                        case "back": Console.WriteLine("\nback"); return;

                    }

                    break;

                case 3:
                    cicte.pushUniform("CICTE: " + "Sport Jersey\n");
                    Console.WriteLine("\nCICTE Sport Jersey Sizes");
                    string[] SportJersey = { "1.) Small", "2.) Medium", "3.) Large" };

                    for (int i = 0; i < SportJersey.Length; i++)
                    {
                        Console.WriteLine(SportJersey[i]);
                    }

                    Console.Write("Enter your size: ");
                    int Jersey_Size;
                    bool SvInput = int.TryParse(Console.ReadLine(), out Jersey_Size);


                    if (!SvInput || Jersey_Size < 1 || Jersey_Size > 3)
                    {
                        Console.WriteLine($"\nInvalid Input ({Jersey_Size}), Please input (1-3)! ");
                    }
                    switch (Jersey_Size)
                    {
                        case 1:
                            cicte.pushSizes("Small\n");
                            break;
                        case 2:
                            cicte.pushSizes("Medium\n");
                            break;
                        case 3:
                            cicte.pushSizes("Large\n");
                            break;
                    }
                    Console.Write("Enter the quantity of your order: ");
                    int Squantity = int.Parse(Console.ReadLine());

                    cicte.pushQuantity(Squantity);

                    Console.Write("Type 'order' to order and 'display' to display your order and 'back': ");
                    string Sdecision = Console.ReadLine();

                    switch (Sdecision)
                    {
                        case "display":
                            Console.Write("\nUniform Price: 30,000,  ");
                            cicte.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cicte.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cicte.DisplayQuantity();
                            Console.Write("\nType 'back': ");
                            string back = Console.ReadLine();

                            if (back == "back")
                            {
                                Console.WriteLine("\nback");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("\nback");
                            }

                            break;

                        case "order":
                            Console.WriteLine("List of you order!");
                            Console.Write("\nUniform Price:30,000 ");
                            cicte.DisplayUniform();
                            Console.Write("\nUniform Sizes: ");
                            cicte.DisplayUniformSize();
                            Console.Write("\nQuantity: ");
                            cicte.DisplayQuantity();
                            Console.Write("\nType yes to proceed payment or no to exit: ");
                            string order = Console.ReadLine();

                            switch (order)
                            {
                                case "yes":
                                    Console.WriteLine("Available payment method: ");
                                    Console.WriteLine("1.) Gcash");
                                    Console.WriteLine("2.) Exit");
                                    Console.Write("Enter your payment method: ");
                                    int payment;

                                    bool paymentValid = int.TryParse(Console.ReadLine(), out payment);

                                    if (!paymentValid || payment < 1 || payment > 2)
                                    {
                                        Console.WriteLine("Invalid Input or not available payment method!");
                                    }

                                    switch (payment)
                                    {
                                        case 1:
                                            Console.WriteLine("Gcash");
                                            Console.WriteLine("Payment: 30,000");
                                            Console.WriteLine("Delivery: 500");
                                            Console.WriteLine($"Total Payment: 30,500");
                                            Console.Write("Type your location: ");
                                            string location = Console.ReadLine();

                                            Console.Write("Type your Gcash number: (11)");
                                            long Gcash = long.Parse(Console.ReadLine());


                                            Console.Write("Proceed to oder Y/n: ");
                                            string proceed = Console.ReadLine();

                                            switch (proceed)
                                            {
                                                case "Y":
                                                    Console.WriteLine($"Thank you! Your order will be deliver on Date: June 6,2070\n Your Location: {location} Number Gcash: {Gcash}");
                                                    break;
                                                case "n":
                                                    Console.WriteLine("Exit");
                                                    return;
                                            }
                                            break;

                                        case 2: Console.WriteLine("\nExit"); return;
                                    }
                                    break;

                                case "no": Console.WriteLine("\nExit"); return;
                            }

                            break;

                        case "back": Console.WriteLine("Back"); return;

                    }
                    break;



            }
        }
    }
}
class OrderList
{
    private string[] Uniforms;
    private int[] Quantity;
    private string[] Uniform_Sizes;
    private int top;
    private int maxSize;

    public OrderList(int size)
    {
        maxSize = size;
        Uniforms = new string[maxSize];
        Uniform_Sizes = new string[maxSize];
        Quantity = new int[maxSize];
        top = -1;
    }

    public bool pushUniform(string item)
    {
        if (top >= maxSize - 1)
        {
            Console.WriteLine($"\nOops You've reached your order limit {maxSize}! :)");
        }
        Console.WriteLine("\nUniform Pushed!");
        Uniforms[++top] = item;
        return true;

    }

    public bool pushSizes(string item)
    {
        if (top >= maxSize - 1)
        {
            Console.WriteLine("\noops You've reached your order limit! ");
        }
        Console.WriteLine("\nSize Pushed!");
        Uniform_Sizes[++top] = item;
        return true;

    }

    public void pushQuantity(int item)
    {
        if (top >= maxSize - 1)
        {
            Console.WriteLine($"\nOops You've rich your order limit {maxSize}! :)");
        }
        Console.WriteLine("\nQuantity Pushed!");
        Quantity[++top] = item;
    }

    public void DisplayUniform()
    {
        if (top == -1)
        {
            Console.WriteLine("Order List is empty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write(Uniforms[i]);
            }
        }
    }

    public void DisplayUniformSize()
    {
        if (top == -1)
        {
            Console.WriteLine("Oder List is empty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write(Uniform_Sizes[i]);
            }
        }
    }

    public void DisplayQuantity()
    {
        if (top == -1)
        {
            Console.WriteLine("Order List is empty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write(Quantity[i] + ",");
            }
        }
    }
}
class Department
{
    public void Uniform()
    {
        while (true)
        {
            Console.WriteLine("\nWelcome to School Uniform Ordering System!\n");

            Console.Write("List of Department Uniform!" +
            "\n1.) CICTE\n" +
            "2.) CAS\n" +
            "3.) CFAS\n" +
            "4.) Exit\n" +
            "Please select a number to choose: ");
            int choice;
            bool validInput = int.TryParse(Console.ReadLine(), out choice);

            if (!validInput || choice < 1 || choice > 4)
            {
                Console.WriteLine("\nInvalid Input! Please Input (1-4)");
            }


            switch (choice)
            {
                case 1:
                    CICTE cicte = new CICTE();
                    cicte.cicte(); break;
                case 2:
                    CAS department2 = new CAS();
                    department2.Uniform(); break;
                case 3:
                    CFAS department3 = new CFAS();
                    department3.Uniform(); break;
                case 4:
                    Console.WriteLine("\nThank You! Come Again!");
                    return;
            }
        }
    }
}
class Admin
{
    public string Username;
    public string Password;

    public Admin()
    {
        Username = "admin";
        Password = "password123";
    }


}
class Login
{
    public bool authentication = false;
    public void login()
    {
        Console.WriteLine("\n>>Login<<");

        Console.Write("\nEnter Username: ");
        string user = Console.ReadLine();

        Console.Write("Enter Password: ");
        string pass = Console.ReadLine();

        Admin admin = new Admin();

        if (user == admin.Username && pass == admin.Password)
        {
            Console.WriteLine("\nLogin Successfully! ");
            Department department = new Department();
            department.Uniform();
        }
        else
        {
            Console.WriteLine("\nInvalid Users and Password! Please input the predefined admin account! ");
            return;
        }
    }

}
class Program
{
    static void Main()
    {
        while (true)
        {
            Login login = new Login();
            login.login();

            if (login.authentication)
            {
                return;
            }
        }
    }
}
