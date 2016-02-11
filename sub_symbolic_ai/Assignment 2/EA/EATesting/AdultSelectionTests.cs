using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EA;

namespace EATesting
{
    [TestClass]
    public class AdultSelectionTests
    {

        

        [TestMethod]
        public void AdultSelectionTesting_When_AdultEqualsChildren()
        {

            List<IPhenotype> children = new List<IPhenotype>();
            List<IPhenotype> adults = new List<IPhenotype>();

            children.Add(new Phenotype(1));
            children.Add(new Phenotype(3));
            children.Add(new Phenotype(5));
            children.Add(new Phenotype(7));
            children.Add(new Phenotype(9));
            children.Add(new Phenotype(11));
            children.Add(new Phenotype(13));
            children.Add(new Phenotype(15));
            children.Add(new Phenotype(17));


            adults.Add(new Phenotype(2));
            adults.Add(new Phenotype(4));
            adults.Add(new Phenotype(6));
            adults.Add(new Phenotype(8));
            adults.Add(new Phenotype(10));
            adults.Add(new Phenotype(12));
            adults.Add(new Phenotype(14));
            adults.Add(new Phenotype(16));
            adults.Add(new Phenotype(18));

            OverProduction overProduction = new OverProduction();
            GenerationalMixing generationalMixing = new GenerationalMixing();
            FullGenerationalReplacement fullGenerationalReplacement = new FullGenerationalReplacement();


            // Case : #adults = #childrens
            // Test overproduction
            List<IPhenotype> result = overProduction.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children, "overproduction method fails with equal size populations");

            // Test GenerationalMixing
            result = generationalMixing.adultSelection(adults, children);
            List<IPhenotype> expected = new List<IPhenotype> { adults[8], adults[7], adults[6], adults[5], adults[4], children[8], children[7], children[6], children[5] };
            CollectionAssert.AreEquivalent(result, expected, "generationalMixing method fails with equal size populations");

            // Test FullGenerationalReplacement
            result = fullGenerationalReplacement.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children, "fullGenerationalReplacement method fails with equal size populations");

            //


        }

        [TestMethod]
        public void AdultSelectionTesting_When_AdultLargerThanChildren()
        {

            List<IPhenotype> children = new List<IPhenotype>();
            List<IPhenotype> adults = new List<IPhenotype>();

            children.Add(new Phenotype(1));
            children.Add(new Phenotype(3));
            children.Add(new Phenotype(5));
            children.Add(new Phenotype(7));
            children.Add(new Phenotype(9));
            children.Add(new Phenotype(13));
            children.Add(new Phenotype(17));


            adults.Add(new Phenotype(2));
            adults.Add(new Phenotype(4));
            adults.Add(new Phenotype(6));
            adults.Add(new Phenotype(8));
            adults.Add(new Phenotype(10));
            adults.Add(new Phenotype(12));
            adults.Add(new Phenotype(14));
            adults.Add(new Phenotype(16));
            adults.Add(new Phenotype(18));

            OverProduction overProduction = new OverProduction();
            GenerationalMixing generationalMixing = new GenerationalMixing();
            FullGenerationalReplacement fullGenerationalReplacement = new FullGenerationalReplacement();


            // Case : #adults = #childrens
            // Test overproduction
            List<IPhenotype> result = overProduction.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children);

            // Test GenerationalMixing
            result = generationalMixing.adultSelection(adults, children);
            List<IPhenotype> expected = new List<IPhenotype> { adults[8], adults[7], adults[6], adults[5], adults[4], adults[3], children[6], children[5], children[4] };
            CollectionAssert.AreEquivalent(result, expected);

            // Test FullGenerationalReplacement
            result = fullGenerationalReplacement.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children);
        }

        [TestMethod]
        public void AdultSelectionTesting_When_ChildrenLargerThanAdults()
        {

            List<IPhenotype> children = new List<IPhenotype>();
            List<IPhenotype> adults = new List<IPhenotype>();

            children.Add(new Phenotype(1));
            children.Add(new Phenotype(3));
            children.Add(new Phenotype(5));
            children.Add(new Phenotype(7));
            children.Add(new Phenotype(9));
            children.Add(new Phenotype(11));
            children.Add(new Phenotype(13));
            children.Add(new Phenotype(15));
            children.Add(new Phenotype(17));


            adults.Add(new Phenotype(2));
            adults.Add(new Phenotype(4));
            adults.Add(new Phenotype(6));
            adults.Add(new Phenotype(8));
            adults.Add(new Phenotype(10));
            adults.Add(new Phenotype(12));

            OverProduction overProduction = new OverProduction();
            GenerationalMixing generationalMixing = new GenerationalMixing();
            FullGenerationalReplacement fullGenerationalReplacement = new FullGenerationalReplacement();


            // Case : #adults = #childrens
            // Test overproduction
            List<IPhenotype> expected = children.GetRange(3, 6);
            List<IPhenotype> result = overProduction.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, expected);

            // Test GenerationalMixing
            result = generationalMixing.adultSelection(adults, children);
            expected = new List<IPhenotype> { adults[5], adults[4], children[8], children[7], children[6], children[5] };
           
            CollectionAssert.AreEquivalent(result, expected);

            // Test FullGenerationalReplacement
            result = fullGenerationalReplacement.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children);
        }


    }
}
