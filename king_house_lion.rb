# Innovation Island

#1) Define a method to set up the game
def setup_game
  puts "Welcome to Innovation Island! Let's set up your game..."
end

#2) Define a method to get the user's name
def get_username
  puts "What is your username?"
  username = gets.chomp
end

#3) Define a method to create a hash with user's island info
def create_island_hash
  puts "Creating your island..."
  island = {
    "name" => "",
    "size" => "small",
    "terrain" => "tropical"
  }
end

#4) Define a method to start the game
def start_game
  puts "Let's get started on Innovation Island!"
end

#5) Create an array with a list of resources
resources = ["lumber", "metal", "stone", "food"]

#6) Define a method to get the user's starting resources
def get_start_resources
  puts "What resources would you like to start with?"
  resources.each do |resource|
    puts "  - #{resource}"
  end
  user_resources = gets.chomp.split(", ")
end

#7) Define a method to update the island hash with user's starting resources
def update_island_hash(island, user_resources)
  island["resources"] = user_resources
  puts "Updated island hash: #{island}"
end

#8) Define a method to print out the tasks the user needs to accomplish
def print_tasks
  puts "Here are the tasks you need to accomplish:"
  puts "  - Build a shelter"
  puts "  - Gather resources"
  puts "  - Collect food"
  puts "  - Explore the island"
end

#9) Define a main method to bring it all together
def main
  setup_game
  username = get_username
  island = create_island_hash
  island["name"] = username
  start_game
  user_resources = get_start_resources
  update_island_hash(island, user_resources)
  print_tasks
end

#10) Call the main method
main