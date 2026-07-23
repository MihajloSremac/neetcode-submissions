class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    
    
    
    isValid(s) {
        
        const closedOpen = {
        ')' : '(',
        ']' : '[',
        '}' : '{'
        }

        let stack = [];

        for (let p of s){
            if(closedOpen[p]){
                if(stack.length > 0 && stack[stack.length-1] === closedOpen[p]){
                    stack.pop();
                }
                else{
                    return false;
                }
            }
            else
                stack.push(p);
        }

        if(stack.length > 0) return false;

        return true; 
    }
}
