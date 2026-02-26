using LeetCodex.Easy;

namespace LeetCodex.Tests.Easy;

/// <summary>
/// Testes para LeetCode #1 - Two Sum (Fácil)
/// https://leetcode.com/problems/two-sum/
/// </summary>
public class P0001_TwoSumTests
{
    private readonly P0001_TwoSum _sut = new();

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void Solve_DeveRetornarIndicesCorretos(int[] nums, int target, int[] expected)
    {
        var resultado = _sut.Solve(nums, target);

        Assert.Equal(expected, resultado);
    }

    [Fact]
    public void Solve_QuandoNaoExisteSolucao_DeveRetornarArrayVazio()
    {
        var resultado = _sut.Solve([1, 2, 3], 100);

        Assert.Empty(resultado);
    }
}