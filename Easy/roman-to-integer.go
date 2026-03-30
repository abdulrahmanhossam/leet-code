package main

// import "fmt"

func romanToInt(s string) int {
	romanMap := map[byte]int{
		'I': 1,
		'V': 5,
		'X': 10,
		'L': 50,
		'C': 100,
		'D': 500,
		'M': 1000,
	}

	total := 0
	lastValue := 0

	for i := len(s) - 1; i >= 0; i-- {
		current := romanMap[s[i]]

		if current < lastValue {
			total = total - current
		} else {
			total = total + current
		}

		lastValue = current
	}

	return total
}

// func main() {
// 	fmt.Println("III ->", romanToInt("III"))
// 	fmt.Println("LVIII ->", romanToInt("LVIII"))
// 	fmt.Println("MCMXCIV ->", romanToInt("MCMXCIV"))
// }
