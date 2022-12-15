
string address = "1.1.1.1";
DefangIPaddr(address);
string DefangIPaddr(string address)
{
   string q = address.Replace(".", "[.]");
    return q;
}