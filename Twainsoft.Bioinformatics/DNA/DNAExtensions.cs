﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twainsoft.Bioinformatics.Exceptions;

namespace Twainsoft.Bioinformatics.DNA
{
    public static class DNAExtensions
    {
        /// <summary>
        /// Takes a DNA string (alphabet with symbols A, C, G and T) and count the symbols.
        /// </summary>
        /// <param name="dna">The DNA string.</param>
        /// <returns>A dictionary with the symbol count per nucleotide.</returns>
        public static Dictionary<char, int> NucleotidesCount(this string dna)
        {
            Dictionary<char, int> nucleotidesCount = new Dictionary<char, int>(4);
            nucleotidesCount.Add('A', 0);
            nucleotidesCount.Add('C', 0);
            nucleotidesCount.Add('G', 0);
            nucleotidesCount.Add('T', 0);

            dna = dna.Trim();

            foreach (var symbol in dna)
            {
                if (nucleotidesCount.ContainsKey(symbol))
                {
                    nucleotidesCount[symbol]++;
                }
                else
                {
                    throw new InvalidDNAException();
                }
            } 

            return nucleotidesCount;   
        }
    }
}