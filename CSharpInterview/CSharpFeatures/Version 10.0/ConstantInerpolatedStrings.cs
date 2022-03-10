using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures.Version_10._0;

internal class ConstantInerpolatedStrings
{
    void InerpolatedStrings()
    {
        const string Language = "C#";
        const string Platform = ".NET";
        const string Version = "10.0";
        const string FullProductName = $"{Platform} - Language: {Language} Version: {Version}"; // Constant Interpolated string

        const string BaseURL = "https://www.youtube.com";
        const string FullyQualifiedURL = $"{BaseURL}/watch?v=Vft4QDUpyWY";
    }


}

internal class NickAttribute<T> : Attribute
{

}
