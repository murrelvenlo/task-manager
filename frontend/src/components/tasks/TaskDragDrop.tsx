// import React, { CSSProperties } from "react";
// import {
//   SortableContext,
//   useSortable,
//   arrayMove,
//   DndContext,
// } from "@dnd-kit/sortable";

// import { Task } from "../../types/tasks/Task";
// import { getStatusString } from "../../utils/Status";

// interface TaskDragDropProps {
//   tasks: Task[];
// }

// const TaskItem: React.FC<{ task: Task }> = ({ task }) => {
//   const { attributes, listeners, setNodeRef, transform, transition } =
//     useSortable({
//       id: task.taskId,
//     });

//   const style: CSSProperties = {
//     transform: transform
//       ? `translate3d(${transform.x}px, ${transform.y}px, 0)`
//       : undefined,
//     transition,
//   };

//   return (
//     <li
//       ref={setNodeRef}
//       style={style}
//       className="bg-gray-100 p-4 rounded-md mb-4"
//       {...attributes}
//       {...listeners}
//     >
//       <p>{task.title}</p>
//       <p>Status: {getStatusString(task.status)}</p>
//     </li>
//   );
// };

// const TaskDragDrop: React.FC<TaskDragDropProps> = ({ tasks }) => {
//   const [items, setItems] = React.useState(tasks);

//   const handleDragEnd = (event: any) => {
//     const { active, over } = event;

//     if (active.id !== over.id) {
//       setItems((prevItems) => {
//         const oldIndex = prevItems.findIndex(
//           (item) => item.taskId === active.id
//         );
//         const newIndex = prevItems.findIndex((item) => item.taskId === over.id);

//         return arrayMove(prevItems, oldIndex, newIndex);
//       });
//     }
//   };

//   return (
//     <DndContext onDragEnd={handleDragEnd}>
//       <SortableContext items={items} strategy={rectSortingStrategy}>
//         <ul>
//           {items.map((task) => (
//             <TaskItem key={task.taskId} task={task} />
//           ))}
//         </ul>
//       </SortableContext>
//     </DndContext>
//   );
// };

// export default TaskDragDrop;
