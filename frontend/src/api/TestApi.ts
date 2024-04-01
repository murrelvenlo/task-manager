import { useQuery, UseQueryResult } from "@tanstack/react-query";
import { Task } from "../types/tasks/Task";
import axios from "axios";

const client = axios.create({
  baseURL: import.meta.env.BASE_URL,
});

const fetchTasks = async (): Promise<Task[]> => {
  console.log("Fetching tasks...");
  try {
    const { data } = await client.get<Task[]>("/get");
    console.log("Fetched tasks:", data);
    return data;
  } catch (error) {
    console.error("Error fetching tasks:", error);
    throw error;
  }
};

export const useFetchTasks = (): UseQueryResult<Task[], Error> => {
  return useQuery({
    queryKey: ["tasks"],
    queryFn: fetchTasks,
  });
};
