using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryECommerce
{
    public interface IPanier
    {
        double Visit(Livre livre);
        double Visit(Fruit fruit);
    }
}
