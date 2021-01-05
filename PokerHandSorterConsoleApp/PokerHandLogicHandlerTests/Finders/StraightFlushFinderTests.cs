using System.Collections.Generic;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	public class StraightFlushFinderTests
	{
		[Fact]
		public void Given_StraightFlush_Doesnt_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("4S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = StraightFlushFinder.IsStraightFlush(sampleCards);

			Assert.False(result);
		}

		[Fact]
		public void Given_StraightFlush_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("5H"),
				new CardModel("6H"),
				new CardModel("7H"),
				new CardModel("8H")
			};

			var result = StraightFlushFinder.IsStraightFlush(sampleCards);

			Assert.True(result);
		}
	}
}
