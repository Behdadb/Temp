#include <iostream>

using namespace std;

int main(){

	int h;
	
	cout<<"Please indicate the height: ";
	cin>>h;
	
	for(int i=0;i<h;i++){
		for(int j=0;j<h+i;j++){
			if(j <= h+i-1 && j >= h-i-1){
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