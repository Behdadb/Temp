#include <iostream>

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