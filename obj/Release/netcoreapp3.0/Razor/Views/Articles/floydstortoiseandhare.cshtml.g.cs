#pragma checksum "/Users/patrik.nusszer/Desktop/Nusstudios/Views/Articles/floydstortoiseandhare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec8f92db7f645a2c88b345e41a38e09c83e8212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_floydstortoiseandhare), @"mvc.1.0.view", @"/Views/Articles/floydstortoiseandhare.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/patrik.nusszer/Desktop/Nusstudios/Views/_ViewImports.cshtml"
using Nusstudios;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec8f92db7f645a2c88b345e41a38e09c83e8212", @"/Views/Articles/floydstortoiseandhare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2753723ec3b7f1744cac33670045c6f2e6d4ce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_floydstortoiseandhare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("keywords", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"linear time, FLoyd\'s tortoise and hare, proof, algorithm, cycle detection, tail, cycle, loop\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("topheading", async() => {
                WriteLiteral("\r\n    Floyd\'s tortoise and hare\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("subheading", async() => {
                WriteLiteral("\r\n    Linear time cycle detection algorithm\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("description", async() => {
                WriteLiteral(@"
    <p>
        Floyd's tortoise and hare is a cycle detection algorithm.<br>
        It is in fact unclear who came up with it first, the name is based on assumptions.<br>
        <br>
        You have a list of nodes.<br>
        The 'last' node is linked to one of the earlier nodes in the list.<br>
        This breaks it into a tail and a cycle, where the tail, a line of nodes runs into a circle of nodes.<br>
        <br>
        We need to find the node where the tail intersects the circle, which we will call cycle entry point/node.<br>
        <br>
        The algorithm does not keep account of any numbers, the only thing we know is when the 2 iterators traversing the node list meets at the same node.<br>
        We have a rabbit (hare) and a turtle (tortoise), the former covers twice the distance of the turtle's, which travels node by node.<br>
        <br>
        Since we have a cycle involved, which may be completely traversed a multiple of times, we need to talk in terms of modulo ari");
                WriteLiteral(@"thmetics.<br>
        <br>
        Let T be the tail length, and C be the cycle length.<br>
        <br>
        r = T mod C<br>
        <br>
        which means:<br>
        T = k*C + r; where 'k' is a natural number, and 'r' is the remainder which is r < C<br>
        <br>
        Let's assume that 'r' equals zero.<br>
        It means that the 2 pointers can not meet until turtle covers (T - 1) distance.<br>
        But it also means that they must meet at the cycle entry point when turtle has covered T distance.<br>
        That is because T % C = 0 in this case.<br>
        We do not stop there of course, because we can not always assume that 'r' is zero.<br>
        What we must do because of this uncertainty, is we set one of the pointers back to the first (head) node of the list.<br>
        We set the speed of both to node by node (1x) and of course it is no surprise they will meet again at the cycle entry node.<br>
        <br>
        The reason why we in fact need this second step");
                WriteLiteral(@" is because 'r' may not be zero.<br>
        So let's consider this case.<br>
        <br>
        This means that the 2 pointers can not meet until turtle covers (T - 1) distance, just like in the former case.<br>
        But here it also means the 2 pointers can not meet until turtle covers T distance, because 'r' is not zero.<br><br>
        <br>
        We need some proof that tells us these 2 pointers will indeed meet at some significant node for the first time.<br>
        There is a less proofish but still formal and very clear method to tell where they meet the first time.<br>
        <br>
        So when turtle has covered T distance, it is exactly at node zero of the cycle, where node zero is the cycle entry node.<br>
        At the same time rabbit is at some node 'r' of the cycle.<br>
        That means rabbit is 'r' ahead of the turtle, but it also means turtle is (C - r) ahead of rabbit.<br>
        Now since rabbit has 2x speed, it will take (C - r) distance to be covered by the tur");
                WriteLiteral(@"tle for the 2 to meet the first time.<br>
        d + (C - r) = 2 d => d = C - r<br>
        So it means the 2 pointers will meet at node (C - r) of the cycle because turtle covered (C - r) nodes from node zero.<br>
        It is significant because it also means that the cycle entry node is 'r' ahead of that node.<br>
        <br>
        We can set up a less intuitive but maybe rather proofish equation for this:<br>
        <br>
        d = 2d + r (mod C)<br>
        Let d = l*C + a, where a = d mod C, so that a < C and 'l' is natural number<br>
        <br>
        l*C+a = 2(l*C+a) + r (mod C);<br>
        l*C+a - l*C = 2a+2lC + r - ((2l+e)*C)<br>
        Modulo was transated to subtraction here, 'e' is an unknown natural number<br>
        <br>
        a = 2a + r - e*C<br>
        <br>
        So we get:<br>
        e*C = a + r<br>
        <br>
        We know that a < C and r < C<br>
        => a + r < 2*C<br>
        <br>
        Which means<br>
        => e*C < 2*C<br>
        e");
                WriteLiteral(@" < 2<br>
        <br>
        From that it follows<br>
        => 'e' is either zero or one<br>
        <br>
        Therefore we need to find solution for:<br>
        1) 0 = a + r<br>
        2) C = a + r<br>
        <br>
        We have already considered the case when 'r' is zero, but if it is not zero, equation 1) should not be considered.<br>
        <br>
        In case of equation 2):<br><br>
        C - r = a<br>
        <br>
        This means that if 'r' is not zero, the 2 iterators can only ever meet on the (C - r) node, on the first, and on any further occasions.<br>
        <br>
        Now we put one of the pointers to the first node of the list, and set the speed of rabbit to 1x.<br>
        After both has travelled 'r' nodes, the one left in the cycle will be at the cycle entry node because it was 'r' ahead of it.<br>
        Now the iterator which was put back to the head of the tail travels k*C distance until it arrives at the cycle entry node,
        since T = k*C + r, ");
                WriteLiteral(@"and 'r' has already been covered.<br>
        <br>
        This also means the other iterator left in the cycle also travels k*C distance.<br>
        Since it started out from the cycle entry node, it must end its journey there as well because 'k' is a positive integer (or zero).<br>
        Intuitively speaking, it will circumvent the cycle completely 'k' times and always arrive back to the cycle entry.<br>
        <br>
        It is more proofish to say that after T covered distance, the put-back pointer must be at cycle entry node.<br>
        At the same time, the other node is at ( (C - r) + r + k*C ) mod C, which is ( (k + 1)*C ) mod C, which is of course zero, which is cycle entry node.<br>
    </p>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("btnname", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("url", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
