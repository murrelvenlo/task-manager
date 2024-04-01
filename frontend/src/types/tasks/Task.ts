import { Id } from "../board/Column";

export type Task = {
  id: Id;
  columnId: Id;
  content: string;
};

// import { Status } from "./Status";
// import { z } from "zod";

// export interface Task {
//   taskId: string;
//   title: string;
//   description: string;
//   dueDate: string;
//   priority: number;
//   status: Status;
//   creatorId: string;
//   creator: number | string;
//   assignedUserId: string;
//   assignedUser: number | string;
//   comments: string;
//   createdAt: string; // Assuming createdAt is a string representing a date in ISO 8601 format
//   updatedAt: string;
// }

// export const TaskSchema = z.object({
//   taskId: z.string(),
//   title: z.string(),
//   description: z.string(),
//   dueDate: z.string(),
//   priority: z.number(),
//   status: z.string(),
//   creatorId: z.string(),
//   creator: z.string(),
//   assignedUserId: z.string(),
//   assignedUser: z.string(),
//   comments: z.string(),
//   createdAt: z.string(),
//   updatedAt: z.string(),
// });
