#define _CRT_SECURE_NO_DEPRECATE
#include <iostream>
#include <iomanip>
#include <fstream>
#include <algorithm>
#include <vector>
#include <string>
#include <cmath>
#include <set>
#include <map>
#include <cstdio>
#include <queue>

using namespace std;
typedef long long ll;
typedef long double ld;

// Do all the work for the code jam problem here.
// Write the answer to a test case, only. No new line.
///////////////////////////////////////////////////////////////////
#define filein "C:/Users/ArchdevilMephisto/Desktop/D-large-practice.in"
#define fileout "C:/Users/ArchdevilMephisto/Desktop/__AoutCPP.out"
void solve()
    {
	cout << "cpp hi";
    }
///////////////////////////////////////////////////////////////////



// Program begins here. Handles writing "Case #: "
int main()
    {
    // Handle reading and writing to file.
    freopen(filein, "r", stdin);
    freopen(fileout, "w", stdout);

    int tt; cin >> tt;
    for(int t = 1; t <= tt; t++)
        {
        cout << "Case #" << t << ": ";
        solve();
        if(t != tt) { cout << "\n"; }
        }
    return 0;
    }