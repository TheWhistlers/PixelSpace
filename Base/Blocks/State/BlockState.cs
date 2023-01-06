using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BlockState
{
    public BlockStateProperty Property { get; set; }
}

public abstract class BlockStateProperty
{
    public string PropertyName { get; set; }
}

public class StringBlockStateProperty : BlockStateProperty
{
    public string PropertyValue { get; set; }

    public StringBlockStateProperty(string propertyName, string propertyValue)
    {
        this.PropertyName = propertyName;
        this.PropertyValue = propertyValue;
    }
}

public class NumberBlockStateProperty : BlockStateProperty
{
    public float PropertyValue { get; set; }

    public NumberBlockStateProperty(string propertyName, float propertyValue)
    {
        this.PropertyName = propertyName;
        this.PropertyValue = propertyValue;
    }
}