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

            List<Individual> children = new List<Individual>();
            List<Individual> adults = new List<Individual>();

            children.Add(new BinaryIndividual(1));
            children.Add(new BinaryIndividual(3));
            children.Add(new BinaryIndividual(5));
            children.Add(new BinaryIndividual(7));
            children.Add(new BinaryIndividual(9));
            children.Add(new BinaryIndividual(11));
            children.Add(new BinaryIndividual(13));
            children.Add(new BinaryIndividual(15));
            children.Add(new BinaryIndividual(17));


            adults.Add(new BinaryIndividual(2));
            adults.Add(new BinaryIndividual(4));
            adults.Add(new BinaryIndividual(6));
            adults.Add(new BinaryIndividual(8));
            adults.Add(new BinaryIndividual(10));
            adults.Add(new BinaryIndividual(12));
            adults.Add(new BinaryIndividual(14));
            adults.Add(new BinaryIndividual(16));
            adults.Add(new BinaryIndividual(18));

            OverProduction overProduction = new OverProduction();
            GenerationalMixing generationalMixing = new GenerationalMixing();
            FullGenerationalReplacement fullGenerationalReplacement = new FullGenerationalReplacement();


            // Case : #adults = #childrens
            // Test overproduction
            List<Individual> result = overProduction.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children, "overproduction method fails with equal size populations");

            // Test GenerationalMixing
            result = generationalMixing.adultSelection(adults, children);
            List<Individual> expected = new List<Individual> { adults[8], adults[7], adults[6], adults[5], adults[4], children[8], children[7], children[6], children[5] };
            CollectionAssert.AreEquivalent(result, expected, "generationalMixing method fails with equal size populations");

            // Test FullGenerationalReplacement
            result = fullGenerationalReplacement.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children, "fullGenerationalReplacement method fails with equal size populations");

            //


        }

        [TestMethod]
        public void AdultSelectionTesting_When_AdultLargerThanChildren()
        {

            List<Individual> children = new List<Individual>();
            List<Individual> adults = new List<Individual>();

            children.Add(new BinaryIndividual(1));
            children.Add(new BinaryIndividual(3));
            children.Add(new BinaryIndividual(5));
            children.Add(new BinaryIndividual(7));
            children.Add(new BinaryIndividual(9));
            children.Add(new BinaryIndividual(13));
            children.Add(new BinaryIndividual(17));


            adults.Add(new BinaryIndividual(2));
            adults.Add(new BinaryIndividual(4));
            adults.Add(new BinaryIndividual(6));
            adults.Add(new BinaryIndividual(8));
            adults.Add(new BinaryIndividual(10));
            adults.Add(new BinaryIndividual(12));
            adults.Add(new BinaryIndividual(14));
            adults.Add(new BinaryIndividual(16));
            adults.Add(new BinaryIndividual(18));

            OverProduction overProduction = new OverProduction();
            GenerationalMixing generationalMixing = new GenerationalMixing();
            FullGenerationalReplacement fullGenerationalReplacement = new FullGenerationalReplacement();


            // Case : #adults = #childrens
            // Test overproduction
            List<Individual> result = overProduction.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children);

            // Test GenerationalMixing
            result = generationalMixing.adultSelection(adults, children);
            List<Individual> expected = new List<Individual> { adults[8], adults[7], adults[6], adults[5], adults[4], adults[3], children[6], children[5], children[4] };
            CollectionAssert.AreEquivalent(result, expected);

            // Test FullGenerationalReplacement
            result = fullGenerationalReplacement.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children);
        }

        [TestMethod]
        public void AdultSelectionTesting_When_ChildrenLargerThanAdults()
        {

            List<Individual> children = new List<Individual>();
            List<Individual> adults = new List<Individual>();


            OverProduction overProduction = new OverProduction();
            GenerationalMixing generationalMixing = new GenerationalMixing();
            FullGenerationalReplacement fullGenerationalReplacement = new FullGenerationalReplacement();


            // Case : #adults = #childrens
            // Test overproduction
            List<Individual> expected = children.GetRange(3, 6);
            List<Individual> result = overProduction.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, expected);

            // Test GenerationalMixing
            result = generationalMixing.adultSelection(adults, children);
            expected = new List<Individual> { adults[5], adults[4], children[8], children[7], children[6], children[5] };
           
            CollectionAssert.AreEquivalent(result, expected);

            // Test FullGenerationalReplacement
            result = fullGenerationalReplacement.adultSelection(adults, children);
            CollectionAssert.AreEquivalent(result, children);
        }


    }
}
