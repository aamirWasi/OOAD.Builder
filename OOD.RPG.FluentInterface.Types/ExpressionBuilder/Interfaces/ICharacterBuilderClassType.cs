using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.RPG.FluentInterface.Types.ExpressionBuilder.Interfaces
{
    public interface ICharacterBuilderClassType
    {
        ICharacterBuilderAge As(ClassType classType);
    }
}
