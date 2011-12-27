﻿using System;
using NUnit.Framework;

namespace TDD_Katas_project.The_WordWrap_Kata
{
    [TestFixture]
    [Category("The Word Wrap Kata")]
    public class WordWrapTest
    {
        [Test]
        public void CanWrapSingleLine()
        {
            Assert.That("Let's\n Go", Is.EqualTo(WordWrap.Wrap("Let's Go", 5)));
        }
        [Test]
        public void CanTestForNullWord()
        {
            Assert.That("", Is.EqualTo(WordWrap.Wrap(null, 5)));
        }
        [Test]
        public void CanTestForNullOrWhiteSpacesWord()
        {
            Assert.That("", Is.EqualTo(WordWrap.Wrap(null, 5)));
            Assert.That("", Is.EqualTo(WordWrap.Wrap(" ", 5)));
        }
        [Test]
        public void CanTestNewLineCharacter()
        {
            Assert.That("\n", Is.EqualTo(WordWrap.Wrap("\n", 1)));
            Assert.That("\nLet's\n Go\noutside.", Is.EqualTo(WordWrap.Wrap("\nLet's Go\noutside.", 5)));
        }
    }
}
