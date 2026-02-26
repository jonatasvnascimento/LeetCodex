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
    [InlineData(new[] { 11, 15, 2, 7 }, 9, new[] { 2, 3 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void P0001_TwoSum_Solucao1(int[] nums, int target, int[] expected)
    {
        var resultado = _sut.Solucao1(nums, target);
        Assert.Equal(expected, resultado);
    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 11, 15, 2, 7 }, 9, new[] { 2, 3 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void P0001_TwoSum_Solucao3(int[] nums, int target, int[] expected)
    {
        var resultado = _sut.Solucao3(nums, target);
        Assert.Equal(expected, resultado);
    }

    [Fact]
    public void Solve_QuandoNaoExisteSolucao_DeveRetornarArrayVazio()
    {
        var resultado = _sut.Solucao3([1, 2, 3], 100);

        Assert.Empty(resultado);
    }
}