import { useQuery } from "@tanstack/react-query";
import { Task } from "../types/tasks/Task";

export const useGetTasks = () => {
  const { VITE_BASE_URL } = import.meta.env;

  const getTasks = (): Promise<Task[]> =>
    fetch(VITE_BASE_URL).then((res) => res.json());

  return useQuery({
    queryKey: ["tasks"],
    queryFn: getTasks,
  });
};
