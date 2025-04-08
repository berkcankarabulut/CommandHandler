<h2>🎮 Command Handler for Unity</h2>

<p>
  This Unity package provides a flexible and extensible <strong>Command Execution System</strong> 
  based on the <strong>Command Pattern</strong>. It enables you to define discrete actions as commands 
  and execute them sequentially with completion callbacks.
</p>

<h3>🧱 Components</h3>

<ul>
  <li>
    <strong>Command.cs</strong><br>
    An abstract base class that defines the structure for all command actions.<br>
    <ul>
      <li><code>Execute()</code> and <code>Undo()</code> methods must be implemented.</li>
      <li>Notifies listeners on completion via <code>OnComplete</code> event.</li>
    </ul>
  </li>
  <li>
    <strong>CommandExecuteHandler.cs</strong><br>
    Handles an ordered array of <code>Command</code> objects and executes them one by one.<br>
    <ul>
      <li>Automatically undoes all commands before execution (<code>ResetAllCommand()</code>).</li>
      <li>Waits for each command to complete before executing the next.</li>
      <li>Emits <code>onAllCommandsExecuted</code> event after all commands are done.</li>
    </ul>
  </li>
</ul>

<h3>🔄 Example Use Case</h3>
<p>This system is useful in:</p>
<ul>
  <li>Tutorial steps execution</li>
  <li>Cutscene scripting</li>
  <li>Sequenced gameplay events (e.g. trap activation, puzzle logic)</li>
  <li>Undo/Redo implementations</li>
</ul>

<h3>✅ Features</h3>
<ul>
  <li>🔁 Full undo support</li>
  <li>✅ Safe execution with validation</li>
  <li>🔔 Completion callback for each command</li>
  <li>🧩 Extensible and clean architecture</li>
</ul>

<h3>📦 How to Use</h3>
<ol>
  <li>Inherit from <code>Command</code> and implement <code>Execute</code> and <code>Undo</code>.</li>
  <li>Create a <code>CommandExecuteHandler</code> and assign your command instances.</li>
  <li>Call <code>ExecuteAllCommands()</code> to run the sequence.</li>
</ol>
