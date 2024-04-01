import { Status } from "../types/tasks/Status";

// Function to convert enum value to string
export const getStatusString = (status: Status): string => {
  switch (status) {
    case Status.Pending:
      return "Pending";
    case Status.InProgress:
      return "In Progress";
    case Status.Completed:
      return "Completed";
    default:
      return "";
  }
};
