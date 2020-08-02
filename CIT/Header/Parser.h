#pragma once

#include "Options.h"

class Parser
{
public:

	static Options parseArgs(int argc, const char* argv[]);
	static void pasteComments(Options&& options);
	static void pasteIntoFile(const std::filesystem::path& path, const std::vector<std::string_view>& comments);
};