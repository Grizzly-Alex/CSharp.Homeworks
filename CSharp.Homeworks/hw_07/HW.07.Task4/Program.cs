/*
A traveling salesman has to visit clients. He got each client's address e.g. "432 Main Long Road St.Louisville OH 43071" as a list.
The basic zipcode format usually consists of two capital letters followed by a white space and five digits.
The list of clients to visit was given as a string of all addresses, each separated from the others by a comma, e.g. :
"123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432".
To ease his travel he wants to group the list by zipcode.

Task:
The method Travel will take two parameters addresses (addresses' list of all clients' as a string) and zipcode and returns a string in the following format:
zipcode:street and town,street and town,.../house number,house number,...
The street numbers must be in the same order as the streets where they belong.
If a given zipcode doesn't exist in the list of clients' addresses return "zipcode:/"

Examples:
string addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";
Travel(addresses, "OH 43071") --> "OH 43071:Main Street St. Louisville,Main Long Road St.Louisville/123,432"
Travel(addresses, "NY 56432") --> "NY 56432:High Street Pollocksville/786"
Travel(addresses, "NY 5643") --> "NY 5643:/"
*/


//data
string addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";

//for tests
string inputZipcode = "OH 43071";
Console.WriteLine(Travel(addresses, inputZipcode)); 


//method
string Travel(string addresses, string zipcode)
{
    string[] addresArray = addresses.Split(',');
    bool zipFound = false;

    //check exist zipcode
    foreach (var address in addresArray)
    {
        if (address.EndsWith(zipcode))
        {
            zipFound = true;
            break;
        }
    }

    //parsing logic
    if (zipFound)
    {
        List<string> listPlaces = new List<string>();
        List<string> listDigits = new List<string>();

        foreach (var address in addresArray)
        {
            if (address.EndsWith(zipcode))
            {
                string digit = address.Substring(0, address.IndexOf(' '));
                string place = address.Substring(digit.Length + 1, address.Length - (digit.Length + 1) - (zipcode.Length + 1));

                listDigits.Add(digit);
                listPlaces.Add(place);
            }
        }

        string groupDigits = string.Join(",", listDigits);
        string groupPlace =  string.Join(",", listPlaces);
     
        return zipcode + ":" + groupPlace + "/" + groupDigits;
    }
    else
    {
        return zipcode + ":/";
    }
}