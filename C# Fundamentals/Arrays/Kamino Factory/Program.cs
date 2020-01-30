namespace Kamino_Factory
{
	using System;
	using System.Linq;

	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			string input = Console.ReadLine();

			int[] bestSequence = new int[n];

			int bestSequenceSum = 0;
			int bestSequenceLength = -1;
			int bestSequenceStartIndex = -1;
			int bestSampleNumber = 0;
			int sampleNumber = 0;

			while (input != "Clone them!")
			{
				sampleNumber++;
				int[] sequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				int sequenceLength = 0;
				int sequenceStartIndex = 0;
				int sequenceEndIndex = 0;
				int sequenceSum = 0;
				bool isBestSequence = false;

				int length = 0;

				for (int i = 0; i < sequence.Length; i++)
				{
					if (sequence[i] != 1)
					{
						length = 0;
						continue;
					}

					length++;

					if (length > sequenceLength)
					{
						sequenceLength = length;
						sequenceEndIndex = i;
					}
				}

				sequenceStartIndex = sequenceEndIndex - sequenceLength + 1;
				sequenceSum = sequence.Sum();

				if (sequenceLength > bestSequenceLength)
				{
					isBestSequence = true;
				}
				else if (sequenceLength == bestSequenceLength)
				{
					if (sequenceStartIndex < bestSequenceStartIndex)
					{
						isBestSequence = true;
					}
					else if (sequenceStartIndex == bestSequenceStartIndex)
					{
						if (sequenceSum > bestSequenceSum)
						{
							isBestSequence = true;
						}
					}
				}

				if (isBestSequence)
				{
					bestSequence = sequence;
					bestSequenceLength = sequenceLength;
					bestSequenceStartIndex = sequenceStartIndex;
					bestSequenceSum = sequenceSum;
					bestSampleNumber = sampleNumber;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSequenceSum}.");
			Console.WriteLine(String.Join(" ", bestSequence));
		}
	}
}