package main

import (
	"strings"
)

func longestCommonPrefix(strs []string) string {
	pref := strs[0] // flower
	for i := 1; i < len(strs); i++ {
		for !strings.HasPrefix(strs[i], pref) {
			pref = pref[:len(pref)-1]

			if pref == "" {
				return ""
			}
		}
	}
	return pref
}
