#include <vector>
#include <list>
#include <map>
#include <set>
#include <queue>
#include <deque>
#include <stack>
#include <bitset>
#include <algorithm>
#include <functional>
#include <numeric>
#include <utility>
#include <sstream>
#include <iostream>
#include <iomanip>
#include <cstdio>
#include <cmath>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(){

	int h;
	
	cout<<"Please indicate the height: ";
	cin>>h;
	
	for(int i=0;i<h;i++){
		for(int j=0;j<=max(i,h-i-1);j++){
			if(j == i || j == h-i-1){
				cout<<"*";
			}
			else{
				cout<<" ";
			}
		}
		cout<<endl;
	}
	

	return 0;
}