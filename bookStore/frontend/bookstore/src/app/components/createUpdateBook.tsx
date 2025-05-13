import { Input } from "antd";
import { BookRequest } from "../services/books";
import Modal from "antd/es/modal/Modal";
import TextArea from "antd/es/input/TextArea";
import { useEffect, useState } from "react";

interface Props {
    mode: Mode;
    values: Book[];
    isModalOpen: boolean;
    handleCancel: () => void;
    handleCreate: (request: BookRequest) => void;
    handleUpdate: (id: string, request: BookRequest) => void;
}

export enum Mode {
    Create,
    Edit
}

export const CreateUpdateBooks = ({
    mode,
    values,
    isModalOpen,
    handleCancel,
    handleCreate, 
    handleUpdate,
}: Props) => {
    const [title, setTitle] = useState<string>("");
    const [description, setDescription] = useState<string>("");
    const [price, setPrice] = useState<number>(1);

    return (
        <Modal 
            title={mode === Mode.Create ? "Добавить книгу" : "Редактировать книгу"}
            open={isModalOpen}
            cancelText={"Отмена"}
            >
                <div className="book_modal">
                    <Input
                        value={title}
                        onChange={(e)} => setTitle(e.target.value)}
                        placeholder="Название"
                    />
                    <TextArea
                        value={description}
                        onChange={(e) => setDescription(e.target.value)}
                    />
                    <Input
                        value={price}
                        onChange={(e) => setPrice(Number(e.target.value))}
                    />
                </div>
            </Modal>
    );
}