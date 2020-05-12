using System;

public class clsSupplier : clssupplierConnection
{
    public string SupplierId;

    public bool active { get; set; }

    public string Valid(string supplierId, string companyName, string stockAvaliablity, bool active)
    {
        throw new NotImplementedException();
    }

    public void find(string supplierId)
    {
        throw new NotImplementedException();
    }
}