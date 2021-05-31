using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProjectTSP
{
    class TsmAlgorithm
    {
        private int N, start;
        private int[,] distance;
        private int minTourCost = int.MaxValue;
        private List<int> tour = new List<int>();
        private bool ranSolver = false;

        public TsmAlgorithm(int[,] distance) : this(0, distance)
        {

        }

        public TsmAlgorithm(int start, int[,] distance)
        {
            this.distance = distance;
            this.start = start;
            N = distance.GetLength(0);
        }

        public List<int> getTour()
        {
            if (!ranSolver)
                solve();

            return tour;
        }
        public int getCost()
        {
            if (!ranSolver)
                solve();
            return minTourCost;
        }
        public static List<int> combinations(int r, int n)
        {
            List<int> subsets = new List<int>();
            combinations(0, 0, r, n, subsets);
            return subsets;
        }
        private static void combinations(int set, int at, int r, int n, List<int> subsets)
        {
            int elementsLeftToPick = n - at;
            if (elementsLeftToPick < r) return;

            if (r == 0)
            {
                subsets.Add(set);
            }
            else
            {
                for (int i = at; i < n; i++)
                {
                    set ^= (1 << i);

                    combinations(set, i + 1, r - 1, n, subsets);

                    set ^= (1 << i);
                }

            }
        }
        private static bool notIn(int elem, int subset)
        {
            return ((1 << elem) & subset) == 0;
        }

        public void solve()
        {
            if (ranSolver) return;

            int end_state = (1 << N) - 1;
            int[,] memo = new int[N, 1 << N];

            for (int end = 0; end < N; end++)
            {
                if (end == start) continue;
                memo[end, (1 << start) | (1 << end)] = distance[start, end];
            }
            for (int r = 3; r <= N; r++)
            {
                foreach (var subset in combinations(r, N))
                {
                    if (notIn(start, subset))
                        continue;
                    for (int next = 0; next < N; next++)
                    {
                        if (next == start || notIn(next, subset))
                            continue;
                        int subsetWithoutNext = subset ^ (1 << next);
                        int minDist = int.MaxValue;

                        for (int end = 0; end < N; end++)
                        {
                            if (end == start || end == next || notIn(end, subset))
                                continue;
                            int newDistance = memo[end, subsetWithoutNext] + distance[end, next];
                            if (newDistance < minDist)
                                minDist = newDistance;
                        }

                        memo[next, subset] = minDist;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (i == start)
                    continue;

                int tourCost = memo[i, end_state] + distance[i, start];

                if (tourCost < minTourCost)
                {
                    minTourCost = tourCost;
                }
            }

            int lastIndex = start;
            int state = end_state;
            tour.Add(start);

            for (int i = 1; i < N; i++)
            {
                int bestIndex = -1;
                int bestDist = int.MaxValue;

                for (int j = 0; j < N; j++)
                {
                    if (j == start || notIn(j, state))
                        continue;

                    int newDist = memo[j, state] + distance[j, lastIndex];

                    if (newDist < bestDist)
                    {
                        bestIndex = j;
                        bestDist = newDist;
                    }

                }
                tour.Add(bestIndex);
                state = state ^ (1 << bestIndex);
                lastIndex = bestIndex;
            }
            tour.Add(start);
            tour.Reverse();

            ranSolver = true;
        }
    }
}

