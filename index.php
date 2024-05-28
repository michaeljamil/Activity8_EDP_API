<?php
header('Content-Type: application/json');

$servername = "localhost";
$username = "root";
$password = "";
$dbname = "edp_act8";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$method = $_SERVER['REQUEST_METHOD'];

if ($method == 'GET') {
    $sql = "SELECT users.id, users.name, users.email, posts.title, posts.content FROM users LEFT JOIN posts ON users.id = posts.user_id";
    $result = $conn->query($sql);

    $data = [];
    while ($row = $result->fetch_assoc()) {
        $data[] = $row;
    }
    echo json_encode($data);

} elseif ($method == 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    $name = $input['name'];
    $email = $input['email'];
    $title = $input['title'];
    $content = $input['content'];

    $stmt = $conn->prepare("INSERT INTO users (name, email) VALUES (?, ?)");
    $stmt->bind_param("ss", $name, $email);
    $stmt->execute();

    $user_id = $stmt->insert_id;

    $stmt = $conn->prepare("INSERT INTO posts (user_id, title, content) VALUES (?, ?, ?)");
    $stmt->bind_param("iss", $user_id, $title, $content);
    $stmt->execute();

    echo json_encode(["message" => "User and post created successfully"]);
}

$conn->close();
?>
