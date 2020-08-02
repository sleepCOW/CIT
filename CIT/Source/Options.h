#pragma once

#include <set>
#include <filesystem>
#include <string_view>

struct Options
{
	std::set<std::filesystem::path> dirs;
	std::set<std::filesystem::path> files;
	std::set<std::filesystem::path> extensions;
	std::vector<std::string_view> comments;
	bool bIsAllFiles = false;
	bool bIsRecursive = false;

	// check if we have this extension
	bool operator==(const std::filesystem::path& extension) const
	{
		// if we check all the files we don't care about particular extension
		if (bIsAllFiles)
		{
			return true;
		}
		// try to find extension in the set
		else if (auto found = extensions.find(extension); found != extensions.end())
		{
			return true;
		}

		return false;
	}
};