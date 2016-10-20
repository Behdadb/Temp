json.extract! todo, :id, :description, :deadline, :created_at, :updated_at
json.url todo_url(todo, format: :json)