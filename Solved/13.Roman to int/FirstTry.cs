public class Solution {
    
    public int RomanToInt(string s) {
       
        int result = 0;
        //dictionary and if prev is less than tho subtract else add.
        //  
        int totalLength = s.Length -1; //3
        int lastIndex = s.Length -1; //2,1,0
        int secondLastIndex = s.Length -2;// 2,1
        
        Dictionary<string,int> dictionary = new Dictionary<string, int>
        {{"I",1},{"V",5},{"X",10},{"L",50},{"C",100},{"D",500},{"M",1000}};

        while(lastIndex >= 0)
        {
            int y;
            int x  = Compare(s,dictionary,lastIndex);
            switch(x)
            {
                case 1:
                if(secondLastIndex > 0)
                {
                         y = Compare(s,dictionary,secondLastIndex);
                        if( y > x)
                        {
                            result += y + x ;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                             break;
                        }
                        if(y < x)
                        {
                            result += x - y;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                }
                        result += 1;
                        lastIndex  = lastIndex -1;
            secondLastIndex = secondLastIndex -1;
                        break;

                case 5:
                if(secondLastIndex > 0)
                {

                 y = Compare(s,dictionary,secondLastIndex);
                        if( y > x)
                        {
                            result += y + x ;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                        if(y < x)
                        {
                            result += x - y;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }

                }
                        result += 5;
                        lastIndex  = lastIndex -1;
            secondLastIndex = secondLastIndex -1;
                        break;
                    
                case 10:
                if(secondLastIndex > 0)
                {
                 y = Compare(s,dictionary,secondLastIndex);
                        if( y > x)
                        {
                            result += y + x ;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                             break;
                        }
                        if(y < x)
                        {
                            result += x - y;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                }
                        result += 10;
                        lastIndex  = lastIndex -1;
            secondLastIndex = secondLastIndex -1;
                        break;
                    
                case 50:
                if(secondLastIndex > 0)
                {
                 y = Compare(s,dictionary,secondLastIndex);
                        if( y > x)
                        {
                            result += y + x ;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                             break;
                        }
                        if(y < x)
                        {
                            result += x - y;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                }
                        result += 50;
                        lastIndex  = lastIndex -1;
            secondLastIndex = secondLastIndex -1;
                        break;
                    
                case 100:
                if(secondLastIndex > 0)
                {
                y = Compare(s,dictionary,secondLastIndex);
                        if( y > x)
                        {
                            result += y + x ;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                             break;
                        }
                        if(y < x)
                        {
                            result +=x - y;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                }
                        result += 100;
                        lastIndex  = lastIndex -1;
            secondLastIndex = secondLastIndex -1;
                        break;
                    
                case 500:
                if(secondLastIndex > 0)
                {

                 y = Compare(s,dictionary,secondLastIndex);
                        if( y > x)
                        {
                            result += y + x ;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                        if(y < x)
                        {
                            result += x - y;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                }

                        result += 500;
            lastIndex  = lastIndex -1;
            secondLastIndex = secondLastIndex -1;
                        break;
                    
                case 1000:
                if(secondLastIndex > 0)
                {
                 y = Compare(s,dictionary,secondLastIndex);
                        if( y > x)
                        {
                            result += y + x ;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                        if(y < x)
                        {
                            result += x - y;
                            lastIndex -= 2 ;
                            secondLastIndex -=2;
                            break;
                        }
                }
                        result += 1000;
            lastIndex  = lastIndex -1;
            secondLastIndex = secondLastIndex -1;
                        break;
                    
                default:
                    return 0;
                
            }

        }
        

        return result;
    }

    private int Compare(string s,  Dictionary<string, int> dictionary, int lastIndex)
    {
        switch(s[lastIndex])
        {
            case 'I':
                return dictionary["I"];
            case 'V':
                return dictionary["V"];
            case 'X':
                return dictionary["X"];
            case 'L':
                return dictionary["L"];
            case 'C':
                return dictionary["C"];
            case 'D':
                return dictionary["D"];
            case 'M':
                return dictionary["M"];
            default:
                return 0;
        }
    }
}