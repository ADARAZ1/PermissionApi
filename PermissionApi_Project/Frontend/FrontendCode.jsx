import React, { useEffect, useState } from "react";

function Frontend() {
  const [users, setUsers] = useState([]);
  const [roles, setRoles] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5267/api/users")
      .then(res => res.json())
      .then(data => setUsers(data));

      fetch("http://localhost:5267/api/roles")

      .then(res => res.json())
      .then(data => setRoles(data));
  }, []);

  return (
    <div>
      <h3>Users</h3>
      <pre>{JSON.stringify(users, null, 2)}</pre>

      <h3>Roles</h3>
      <pre>{JSON.stringify(roles, null, 2)}</pre>
    </div>
  );
}

export default Frontend;
