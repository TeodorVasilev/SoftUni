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

			int sampleNumber = 0;
			int bestSequenceIndex = 0;
			int bestSequenceLength = 0;
			int bestSampleNumber = 0;

			int[] bestSequence = new int[n];

			while (input != "Clone them!")
			{
				int[] sequence = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				sampleNumber++;

				int sequenceLength = 0;
				int sequenceIndex = 0;

				for (int i = 0; i < n - 1; i++)
				{
					if (sequence[i] == 1)
					{
						if (sequence[i] == sequence[i + 1])
						{
							sequenceIndex = i;
							sequenceLength++;
						}
					}
					else
					{
						continue;
					}
				}

				if (sequenceLength > bestSequenceLength)
				{
					bestSequenceLength = sequenceLength;
					bestSequenceIndex = sequenceIndex;
					bestSequence = sequence;
					bestSampleNumber = sampleNumber;
				}
				else if (sequenceLength == bestSequenceLength)
				{
					if (sequenceIndex < bestSequenceIndex)
					{
						bestSequenceIndex = sequenceIndex;
						bestSequence = sequence;
						bestSampleNumber = sampleNumber;
					}
					else if (sequenceIndex == bestSequenceIndex)
					{
						if (sequence.Sum() > bestSequence.Sum())
						{
							bestSequence = sequence;
							bestSampleNumber = sampleNumber;
						}
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSequence.Sum()}.");
			Console.WriteLine(string.Join(" ", bestSequence));
		}
	}
}