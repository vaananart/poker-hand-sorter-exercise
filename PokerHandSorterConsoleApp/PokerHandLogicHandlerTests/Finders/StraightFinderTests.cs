using System.Collections.Generic;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	public class StraightFinderTests
	{
		[Fact]
		public void Given_Straight_Doesnt_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("4S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = StraightFinder.IsStraight(sampleCards);

			Assert.False(result);
		}

		[Fact]
		public void Given_Straight_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("5C"),
				new CardModel("6S"),
				new CardModel("7C"),
				new CardModel("8D")
			};

			var result = StraightFinder.IsStraight(sampleCards);

			Assert.True(result);
		}
	}
}
