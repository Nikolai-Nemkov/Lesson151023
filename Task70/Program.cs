// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void intSum(int M, int N) 
{
    if (M > N) return intSum(N, M);
    if (N==M) return M;
    return M + intSum(M + 1, N);
}
console.log(sum (1, 100)); // 5050
console.log(intSum(100, 1)); // 5050