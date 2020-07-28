#pragma checksum "/Users/patrik.nusszer/Desktop/Nusstudios/Views/Articles/mergesort.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20893c921115392e6a549fd1ad78e74b0765a50b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_mergesort), @"mvc.1.0.view", @"/Views/Articles/mergesort.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20893c921115392e6a549fd1ad78e74b0765a50b", @"/Views/Articles/mergesort.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2753723ec3b7f1744cac33670045c6f2e6d4ce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_mergesort : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("keywords", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"Neumann John, Neumann János, mergesort, array sorting, nlogn\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("topheading", async() => {
                WriteLiteral("\r\n    Mergesort\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("subheading", async() => {
                WriteLiteral("\r\n    O(nlogn) sorting algorithm\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("description", async() => {
                WriteLiteral(@"
    <p>
        Mergesort is a linear collection (or sequence) sorting algorithm by Neumann János, Hungarian informatician.<br>
        <br>
        Like any other sorting algorithm, it can be used on collections of any type where the relational operation ""larger than"" (or smaller than) can be defined for 2 objects of the same type. (If it is not a number, it could also be a string)<br>
        <br>
        It is one of the 2 sorting algos that have a deterministic time complexity of O(nlogn).<br>
        It is also the faster one, as heapsort is slower in practise because of cache misses.<br>
        <br>
        Only quicksort is able to beat it, which has a non-deterministic (randomised) average O(nlogn) time complexity.<br>
        That is because quicksort is an in-place algorithm requiring no auxiliary space, and that lack of extra memory management can make it perform somewhat better given you have luck to avoid the O(n^2) worst case.<br>
        <br>
        It employs a concept called ""d");
                WriteLiteral(@"ivide and conquer"".<br>
        It breaks down recursively a problem into subproblems, until it can solve the whole.<br>
        <br>
        Mergesort makes use of a function called ""merge"", which turns 2 already sorted sequences into 1 sorted in deterministic O(n+m) time complexity, where 'm' and 'n' are lengths of the 2 input sequences.<br>
        <br>
        How does mergesort use it?<br>
        It will recursively halve the subsequences of the previous level into the next until the their length is 1.<br>
        That will cause each level to have roughly equal sizes not considering odd sequence sizes because on the top level you have the original sequence whose halves might have at most a difference of one.<br>
        <br>
        We can apply merge to the 2 halves on the 1 lower level of every subsequence on the 1 larger level once those halves are sorted.<br>
        On the lowest level where you have groups of halves of sizes 1, then those by definition already sorted sequences, and are ");
                WriteLiteral(@"ready to be merged group by group back into the subsequences of the one larger level, and when it is done, it means each subsequence on the 1 larger level are also sorted and ready for merging back into the even larger level and so on.<br>
        <br>
        We have roughly equal subsequence sizes on each level, so it means log_2(array length) must tell you with an error of at most 1 how many levels there are going to be in this subsequence hierarchy because the sorted subsequence size grows by a factor of 2 on each level.<br>
        <br>
        How does the merge function work?<br>
        It sets up 2 iterators to the beggining of the 2 sorted input arrays where it expects the smallest numbers of each two.<br>
        It sets up an auxiliary (n+m) sized array where it will start copying the numbers from the 2 arrays in ascending order from index zero.<br>
        <br>
        All it does is it keeps copying numbers from one array into the result until the current number in the other array is lar");
                WriteLiteral(@"ger.<br>
        We need to prove that those copied numbers come in ascending order and no other number nonconsidered number is smaller than the previous largest.<br>
        It is of course true, both, because both arrays are sorted, so if a larger number is encountered in the other array, only larger ones follow in it, and also in the current array only larger numbers follow.<br>
        <br>
        You see that on each level, each element of the original array is being processed by merge function.<br>
        We have log_2(n) levels, so it means O(n*log_2(n)) operations all in all.<br>
    </p>
    <pre><code class=""language-cpp"">
    template &lt;typename T&gt;
    void merge(T *first, size_t firstLen, T *second, size_t secondLen, T *dest) {
        size_t toIndex = 0;
        size_t firstIndex = 0;
        size_t secondIndex = 0;
        T *toFirst = (T *)malloc(sizeof(T) * (firstLen + secondLen));

        while (firstIndex != firstLen && secondIndex != secondLen) {
            T &fromF");
                WriteLiteral(@"irst = first[firstIndex];
            T &fromSecond = second[secondIndex];

            if (fromFirst &gt; fromSecond) {
                toFirst[toIndex] = second[secondIndex];
                toIndex++;
                secondIndex++;
            }
            else {
                toFirst[toIndex] = first[firstIndex];
                toIndex++;
                firstIndex++;
            }
        }

        if (firstIndex &lt; firstLen)
            memcpy(toFirst + toIndex, first + firstIndex, (firstLen - firstIndex) * sizeof(T));
        else if (secondIndex &lt; secondLen)
            memcpy(toFirst + toIndex, second + secondIndex, (secondLen - secondIndex) * sizeof(T));

        for (size_t i = 0; i &lt; firstLen + secondLen; i++)
            dest[i] = toFirst[i];

        free(toFirst);
    }

    template &lt;typename T&gt;
    void mergesort(T *first, size_t len) {
        if (len == 1) {
            *first = move(*first);
            return;
        }

        size_t m");
                WriteLiteral(" = (len / 2);\r\n        mergesort(first, m);\r\n        mergesort(first + m, len - m);\r\n        merge(first, m, first + m, len - m, first);\r\n    }\r\n</code></pre>\r\n");
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
