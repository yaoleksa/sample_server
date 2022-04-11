# include <iostream>
# include <math.h>
int main(){
float a=0, b=0, c=0;
    std::cin>>a>>b>>c;
    float D=b*b-4*a*c; //std::cout<<"D is "<<D<<std::endl;
    if(D<0){
        std::cout<<"Error !"<<std::endl;
        return 1;
    } else{
    D=sqrt(D); //std::cout<<"D is "<<D<<std::endl;
    }
    float x1=(-b-D)/(2*a);
    float x2=(-b+D)/(2*a);
    std::cout<<"x1 = "<<x1<<std::endl;
    std::cout<<"x2 = "<<x2<<std::endl;
}
