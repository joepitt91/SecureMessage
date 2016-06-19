CREATE TABLE [Account] (
	[Username]		TEXT	NOT NULL	UNIQUE,
	[AccountID]		TEXT	NOT NULL,
	[DisplayName]	TEXT	NOT NULL,
	[DisplayImage]	BLOB	NOT NULL,
	[Email]			TEXT,
	[IV]			BLOB	NOT NULL,
	[Salt]			BLOB	NOT NULL,
	[CheckValue]	BLOB	NOT NULL,
	PRIMARY KEY(Username)
);

CREATE TABLE [Key] (
	[KeyID]			INTEGER	NOT NULL	UNIQUE,
	[KeyType]		TEXT	NOT NULL,
	[PublicKey]		TEXT	NOT NULL,
	[IV]			BLOB	NOT NULL,
	[PrivateCrypt]	BLOB	NOT NULL,
	[Created]		TEXT	NOT NULL,
	[Revoked]		TEXT,
	PRIMARY KEY(KeyID)
);

CREATE TABLE [Inbox] (
	[MessageID]		TEXT	NOT NULL	UNIQUE,
	[Sender]		BLOB	NOT NULL,
	[Receiver]		BLOB	NOT NULL,
	[Subject]		TEXT	NOT NULL,
	[Sent]			TEXT	NOT NULL,
	[Timestamp]		BLOB,
	[Expires]		TEXT,
	[Crypt]			BLOB	NOT NULL,
	[IV]			BLOB	NOT NULL,
	[Signature]		BLOB	NOT NULL,
	PRIMARY KEY(MessageID)
);

CREATE TABLE [InboxAttachment] (
	[AttachmentID]	TEXT	NOT NULL	UNIQUE,
	[MessageID]		TEXT	NOT NULL,
	[FileName]		TEXT	NOT NULL,
	[Crypt]			BLOB	NOT NULL,
	[IV]			BLOB	NOT NULL,
	[Timestamp]		BLOB,
	[Signature]		BLOB	NOT NULL,
	PRIMARY KEY(AttachmentID)
);

CREATE TABLE [SentBox] (
	[MessageID]		TEXT	NOT NULL	UNIQUE,
	[Sender]		BLOB	NOT NULL,
	[Receiver]		BLOB	NOT NULL,
	[Subject]		TEXT	NOT NULL,
	[Sent]			TEXT	NOT NULL,
	[Timestamp]		BLOB,
	[Expires]		TEXT,
	[Crypt]			BLOB	NOT NULL,
	[IV]			BLOB	NOT NULL,
	[Signature]		BLOB	NOT NULL,
	PRIMARY KEY(MessageID)
);

CREATE TABLE [SentBoxAttachment] (
	[AttachmentID]	TEXT	NOT NULL	UNIQUE,
	[MessageID]		TEXT	NOT NULL,
	[FileName]		TEXT	NOT NULL,
	[Crypt]			BLOB	NOT NULL,
	[IV]			BLOB	NOT NULL,
	[Timestamp]		BLOB,
	[Signature]		BLOB	NOT NULL,
	PRIMARY KEY(AttachmentID)
);

CREATE TABLE [Contact] (
	[ContactID]		INTEGER	NOT NULL	UNIQUE,
	[DisplayName]	TEXT	NOT NULL,
	[DisplayImage]	BLOB,
	[Email]			TEXT,
	[PublicKey]		TEXT	NOT NULL,
	[ContactBlob]	BLOB	NOT NULL,
	PRIMARY KEY(ContactID)
);