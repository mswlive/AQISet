﻿using System;
using System.Xml;

namespace Helper.WCFbin
{
    internal class WcfBinaryDictionary
    {
        public static XmlDictionary CreateWcfBinaryDictionary()
        {
            XmlDictionary dictionary = new XmlDictionary();
            dictionary.Add("mustUnderstand");
            dictionary.Add("Envelope");
            dictionary.Add("http://www.w3.org/2003/05/soap-envelope");
            dictionary.Add("http://www.w3.org/2005/08/addressing");
            dictionary.Add("Header");
            dictionary.Add("Action");
            dictionary.Add("To");
            dictionary.Add("Body");
            dictionary.Add("Algorithm");
            dictionary.Add("RelatesTo");
            dictionary.Add("http://www.w3.org/2005/08/addressing/anonymous");
            dictionary.Add("URI");
            dictionary.Add("Reference");
            dictionary.Add("MessageID");
            dictionary.Add("Id");
            dictionary.Add("Identifier");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/rm");
            dictionary.Add("Transforms");
            dictionary.Add("Transform");
            dictionary.Add("DigestMethod");
            dictionary.Add("Address");
            dictionary.Add("ReplyTo");
            dictionary.Add("SequenceAcknowledgement");
            dictionary.Add("AcknowledgementRange");
            dictionary.Add("Upper");
            dictionary.Add("Lower");
            dictionary.Add("BufferRemaining");
            dictionary.Add("http://schemas.microsoft.com/ws/2006/05/rm");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/rm/SequenceAcknowledgement");
            dictionary.Add("SecurityTokenReference");
            dictionary.Add("Sequence");
            dictionary.Add("MessageNumber");
            dictionary.Add("http://www.w3.org/2000/09/xmldsig#");
            dictionary.Add("http://www.w3.org/2000/09/xmldsig#enveloped-signature");
            dictionary.Add("KeyInfo");
            dictionary.Add("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/sc");
            dictionary.Add("DerivedKeyToken");
            dictionary.Add("Nonce");
            dictionary.Add("Signature");
            dictionary.Add("SignedInfo");
            dictionary.Add("CanonicalizationMethod");
            dictionary.Add("SignatureMethod");
            dictionary.Add("SignatureValue");
            dictionary.Add("DataReference");
            dictionary.Add("EncryptedData");
            dictionary.Add("EncryptionMethod");
            dictionary.Add("CipherData");
            dictionary.Add("CipherValue");
            dictionary.Add("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");
            dictionary.Add("Security");
            dictionary.Add("Timestamp");
            dictionary.Add("Created");
            dictionary.Add("Expires");
            dictionary.Add("Length");
            dictionary.Add("ReferenceList");
            dictionary.Add("ValueType");
            dictionary.Add("Type");
            dictionary.Add("EncryptedHeader");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-wssecurity-secext-1.1.xsd");
            dictionary.Add("RequestSecurityTokenResponseCollection");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust#BinarySecret");
            dictionary.Add("http://schemas.microsoft.com/ws/2006/02/transactions");
            dictionary.Add("s");
            dictionary.Add("Fault");
            dictionary.Add("MustUnderstand");
            dictionary.Add("role");
            dictionary.Add("relay");
            dictionary.Add("Code");
            dictionary.Add("Reason");
            dictionary.Add("Text");
            dictionary.Add("Node");
            dictionary.Add("Role");
            dictionary.Add("Detail");
            dictionary.Add("Value");
            dictionary.Add("Subcode");
            dictionary.Add("NotUnderstood");
            dictionary.Add("qname");
            dictionary.Add("");
            dictionary.Add("From");
            dictionary.Add("FaultTo");
            dictionary.Add("EndpointReference");
            dictionary.Add("PortType");
            dictionary.Add("ServiceName");
            dictionary.Add("PortName");
            dictionary.Add("ReferenceProperties");
            dictionary.Add("RelationshipType");
            dictionary.Add("Reply");
            dictionary.Add("a");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2006/02/addressingidentity");
            dictionary.Add("Identity");
            dictionary.Add("Spn");
            dictionary.Add("Upn");
            dictionary.Add("Rsa");
            dictionary.Add("Dns");
            dictionary.Add("X509v3Certificate");
            dictionary.Add("http://www.w3.org/2005/08/addressing/fault");
            dictionary.Add("ReferenceParameters");
            dictionary.Add("IsReferenceParameter");
            dictionary.Add("http://www.w3.org/2005/08/addressing/reply");
            dictionary.Add("http://www.w3.org/2005/08/addressing/none");
            dictionary.Add("Metadata");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/08/addressing");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/08/addressing/role/anonymous");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/08/addressing/fault");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/06/addressingex");
            dictionary.Add("RedirectTo");
            dictionary.Add("Via");
            dictionary.Add("http://www.w3.org/2001/10/xml-exc-c14n#");
            dictionary.Add("PrefixList");
            dictionary.Add("InclusiveNamespaces");
            dictionary.Add("ec");
            dictionary.Add("SecurityContextToken");
            dictionary.Add("Generation");
            dictionary.Add("Label");
            dictionary.Add("Offset");
            dictionary.Add("Properties");
            dictionary.Add("Cookie");
            dictionary.Add("wsc");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/sc");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/sc/dk");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/sc/sct");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/RST/SCT");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/RSTR/SCT");
            dictionary.Add("RenewNeeded");
            dictionary.Add("BadContextToken");
            dictionary.Add("c");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/sc/dk");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/sc/sct");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RST/SCT");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/SCT");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RST/SCT/Renew");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/SCT/Renew");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RST/SCT/Cancel");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/SCT/Cancel");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#aes128-cbc");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-aes128");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#aes192-cbc");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-aes192");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#aes256-cbc");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-aes256");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#des-cbc");
            dictionary.Add("http://www.w3.org/2000/09/xmldsig#dsa-sha1");
            dictionary.Add("http://www.w3.org/2001/10/xml-exc-c14n#WithComments");
            dictionary.Add("http://www.w3.org/2000/09/xmldsig#hmac-sha1");
            dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha256");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/sc/dk/p_sha1");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#ripemd160");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p");
            dictionary.Add("http://www.w3.org/2000/09/xmldsig#rsa-sha1");
            dictionary.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha256");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#rsa-1_5");
            dictionary.Add("http://www.w3.org/2000/09/xmldsig#sha1");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#sha256");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#sha512");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#tripledes-cbc");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#kw-tripledes");
            dictionary.Add("http://schemas.xmlsoap.org/2005/02/trust/tlsnego#TLS_Wrap");
            dictionary.Add("http://schemas.xmlsoap.org/2005/02/trust/spnego#GSS_Wrap");
            dictionary.Add("http://schemas.microsoft.com/ws/2006/05/security");
            dictionary.Add("dnse");
            dictionary.Add("o");
            dictionary.Add("Password");
            dictionary.Add("PasswordText");
            dictionary.Add("Username");
            dictionary.Add("UsernameToken");
            dictionary.Add("BinarySecurityToken");
            dictionary.Add("EncodingType");
            dictionary.Add("KeyIdentifier");
            dictionary.Add("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary");
            dictionary.Add("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#HexBinary");
            dictionary.Add("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Text");
            dictionary.Add("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509SubjectKeyIdentifier");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-kerberos-token-profile-1.1#GSS_Kerberosv5_AP_REQ");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-kerberos-token-profile-1.1#GSS_Kerberosv5_AP_REQ1510");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.0#SAMLAssertionID");
            dictionary.Add("Assertion");
            dictionary.Add("urn:oasis:names:tc:SAML:1.0:assertion");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-rel-token-profile-1.0.pdf#license");
            dictionary.Add("FailedAuthentication");
            dictionary.Add("InvalidSecurityToken");
            dictionary.Add("InvalidSecurity");
            dictionary.Add("k");
            dictionary.Add("SignatureConfirmation");
            dictionary.Add("TokenType");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-soap-message-security-1.1#ThumbprintSHA1");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-soap-message-security-1.1#EncryptedKey");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-soap-message-security-1.1#EncryptedKeySHA1");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLV1.1");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLV2.0");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLID");
            dictionary.Add("AUTH-HASH");
            dictionary.Add("RequestSecurityTokenResponse");
            dictionary.Add("KeySize");
            dictionary.Add("RequestedTokenReference");
            dictionary.Add("AppliesTo");
            dictionary.Add("Authenticator");
            dictionary.Add("CombinedHash");
            dictionary.Add("BinaryExchange");
            dictionary.Add("Lifetime");
            dictionary.Add("RequestedSecurityToken");
            dictionary.Add("Entropy");
            dictionary.Add("RequestedProofToken");
            dictionary.Add("ComputedKey");
            dictionary.Add("RequestSecurityToken");
            dictionary.Add("RequestType");
            dictionary.Add("Context");
            dictionary.Add("BinarySecret");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/spnego");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/tlsnego");
            dictionary.Add("wst");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/trust");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/RST/Issue");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/RSTR/Issue");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/Issue");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/CK/PSHA1");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/SymmetricKey");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/security/trust/Nonce");
            dictionary.Add("KeyType");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/trust/SymmetricKey");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/04/trust/PublicKey");
            dictionary.Add("Claims");
            dictionary.Add("InvalidRequest");
            dictionary.Add("RequestFailed");
            dictionary.Add("SignWith");
            dictionary.Add("EncryptWith");
            dictionary.Add("EncryptionAlgorithm");
            dictionary.Add("CanonicalizationAlgorithm");
            dictionary.Add("ComputedKeyAlgorithm");
            dictionary.Add("UseKey");
            dictionary.Add("http://schemas.microsoft.com/net/2004/07/secext/WS-SPNego");
            dictionary.Add("http://schemas.microsoft.com/net/2004/07/secext/TLSNego");
            dictionary.Add("t");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RST/Issue");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/Issue");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/Issue");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/SymmetricKey");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/CK/PSHA1");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/Nonce");
            dictionary.Add("RenewTarget");
            dictionary.Add("CancelTarget");
            dictionary.Add("RequestedTokenCancelled");
            dictionary.Add("RequestedAttachedReference");
            dictionary.Add("RequestedUnattachedReference");
            dictionary.Add("IssuedTokens");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/Renew");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/Cancel");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/PublicKey");
            dictionary.Add("Access");
            dictionary.Add("AccessDecision");
            dictionary.Add("Advice");
            dictionary.Add("AssertionID");
            dictionary.Add("AssertionIDReference");
            dictionary.Add("Attribute");
            dictionary.Add("AttributeName");
            dictionary.Add("AttributeNamespace");
            dictionary.Add("AttributeStatement");
            dictionary.Add("AttributeValue");
            dictionary.Add("Audience");
            dictionary.Add("AudienceRestrictionCondition");
            dictionary.Add("AuthenticationInstant");
            dictionary.Add("AuthenticationMethod");
            dictionary.Add("AuthenticationStatement");
            dictionary.Add("AuthorityBinding");
            dictionary.Add("AuthorityKind");
            dictionary.Add("AuthorizationDecisionStatement");
            dictionary.Add("Binding");
            dictionary.Add("Condition");
            dictionary.Add("Conditions");
            dictionary.Add("Decision");
            dictionary.Add("DoNotCacheCondition");
            dictionary.Add("Evidence");
            dictionary.Add("IssueInstant");
            dictionary.Add("Issuer");
            dictionary.Add("Location");
            dictionary.Add("MajorVersion");
            dictionary.Add("MinorVersion");
            dictionary.Add("NameIdentifier");
            dictionary.Add("Format");
            dictionary.Add("NameQualifier");
            dictionary.Add("Namespace");
            dictionary.Add("NotBefore");
            dictionary.Add("NotOnOrAfter");
            dictionary.Add("saml");
            dictionary.Add("Statement");
            dictionary.Add("Subject");
            dictionary.Add("SubjectConfirmation");
            dictionary.Add("SubjectConfirmationData");
            dictionary.Add("ConfirmationMethod");
            dictionary.Add("urn:oasis:names:tc:SAML:1.0:cm:holder-of-key");
            dictionary.Add("urn:oasis:names:tc:SAML:1.0:cm:sender-vouches");
            dictionary.Add("SubjectLocality");
            dictionary.Add("DNSAddress");
            dictionary.Add("IPAddress");
            dictionary.Add("SubjectStatement");
            dictionary.Add("urn:oasis:names:tc:SAML:1.0:am:unspecified");
            dictionary.Add("xmlns");
            dictionary.Add("Resource");
            dictionary.Add("UserName");
            dictionary.Add("urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName");
            dictionary.Add("EmailName");
            dictionary.Add("urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress");
            dictionary.Add("u");
            dictionary.Add("ChannelInstance");
            dictionary.Add("http://schemas.microsoft.com/ws/2005/02/duplex");
            dictionary.Add("Encoding");
            dictionary.Add("MimeType");
            dictionary.Add("CarriedKeyName");
            dictionary.Add("Recipient");
            dictionary.Add("EncryptedKey");
            dictionary.Add("KeyReference");
            dictionary.Add("e");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#Element");
            dictionary.Add("http://www.w3.org/2001/04/xmlenc#Content");
            dictionary.Add("KeyName");
            dictionary.Add("MgmtData");
            dictionary.Add("KeyValue");
            dictionary.Add("RSAKeyValue");
            dictionary.Add("Modulus");
            dictionary.Add("Exponent");
            dictionary.Add("X509Data");
            dictionary.Add("X509IssuerSerial");
            dictionary.Add("X509IssuerName");
            dictionary.Add("X509SerialNumber");
            dictionary.Add("X509Certificate");
            dictionary.Add("AckRequested");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/rm/AckRequested");
            dictionary.Add("AcksTo");
            dictionary.Add("Accept");
            dictionary.Add("CreateSequence");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/rm/CreateSequence");
            dictionary.Add("CreateSequenceRefused");
            dictionary.Add("CreateSequenceResponse");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/rm/CreateSequenceResponse");
            dictionary.Add("FaultCode");
            dictionary.Add("InvalidAcknowledgement");
            dictionary.Add("LastMessage");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/rm/LastMessage");
            dictionary.Add("LastMessageNumberExceeded");
            dictionary.Add("MessageNumberRollover");
            dictionary.Add("Nack");
            dictionary.Add("netrm");
            dictionary.Add("Offer");
            dictionary.Add("r");
            dictionary.Add("SequenceFault");
            dictionary.Add("SequenceTerminated");
            dictionary.Add("TerminateSequence");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2005/02/rm/TerminateSequence");
            dictionary.Add("UnknownSequence");
            dictionary.Add("http://schemas.microsoft.com/ws/2006/02/tx/oletx");
            dictionary.Add("oletx");
            dictionary.Add("OleTxTransaction");
            dictionary.Add("PropagationToken");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wscoor");
            dictionary.Add("wscoor");
            dictionary.Add("CreateCoordinationContext");
            dictionary.Add("CreateCoordinationContextResponse");
            dictionary.Add("CoordinationContext");
            dictionary.Add("CurrentContext");
            dictionary.Add("CoordinationType");
            dictionary.Add("RegistrationService");
            dictionary.Add("Register");
            dictionary.Add("RegisterResponse");
            dictionary.Add("ProtocolIdentifier");
            dictionary.Add("CoordinatorProtocolService");
            dictionary.Add("ParticipantProtocolService");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wscoor/CreateCoordinationContext");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wscoor/CreateCoordinationContextResponse");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wscoor/Register");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wscoor/RegisterResponse");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wscoor/fault");
            dictionary.Add("ActivationCoordinatorPortType");
            dictionary.Add("RegistrationCoordinatorPortType");
            dictionary.Add("InvalidState");
            dictionary.Add("InvalidProtocol");
            dictionary.Add("InvalidParameters");
            dictionary.Add("NoActivity");
            dictionary.Add("ContextRefused");
            dictionary.Add("AlreadyRegistered");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat");
            dictionary.Add("wsat");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Completion");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Durable2PC");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Volatile2PC");
            dictionary.Add("Prepare");
            dictionary.Add("Prepared");
            dictionary.Add("ReadOnly");
            dictionary.Add("Commit");
            dictionary.Add("Rollback");
            dictionary.Add("Committed");
            dictionary.Add("Aborted");
            dictionary.Add("Replay");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Commit");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Rollback");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Committed");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Aborted");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Prepare");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Prepared");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/ReadOnly");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/Replay");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2004/10/wsat/fault");
            dictionary.Add("CompletionCoordinatorPortType");
            dictionary.Add("CompletionParticipantPortType");
            dictionary.Add("CoordinatorPortType");
            dictionary.Add("ParticipantPortType");
            dictionary.Add("InconsistentInternalState");
            dictionary.Add("mstx");
            dictionary.Add("Enlistment");
            dictionary.Add("protocol");
            dictionary.Add("LocalTransactionId");
            dictionary.Add("IsolationLevel");
            dictionary.Add("IsolationFlags");
            dictionary.Add("Description");
            dictionary.Add("Loopback");
            dictionary.Add("RegisterInfo");
            dictionary.Add("ContextId");
            dictionary.Add("TokenId");
            dictionary.Add("AccessDenied");
            dictionary.Add("InvalidPolicy");
            dictionary.Add("CoordinatorRegistrationFailed");
            dictionary.Add("TooManyEnlistments");
            dictionary.Add("Disabled");
            dictionary.Add("ActivityId");
            dictionary.Add("http://schemas.microsoft.com/2004/09/ServiceModel/Diagnostics");
            dictionary.Add("http://docs.oasis-open.org/wss/oasis-wss-kerberos-token-profile-1.1#Kerberosv5APREQSHA1");
            dictionary.Add("http://schemas.xmlsoap.org/ws/2002/12/policy");
            dictionary.Add("FloodMessage");
            dictionary.Add("LinkUtility");
            dictionary.Add("Hops");
            dictionary.Add("http://schemas.microsoft.com/net/2006/05/peer/HopCount");
            dictionary.Add("PeerVia");
            dictionary.Add("http://schemas.microsoft.com/net/2006/05/peer");
            dictionary.Add("PeerFlooder");
            dictionary.Add("PeerTo");
            dictionary.Add("http://schemas.microsoft.com/ws/2005/05/routing");
            dictionary.Add("PacketRoutable");
            dictionary.Add("http://schemas.microsoft.com/ws/2005/05/addressing/none");
            dictionary.Add("http://schemas.microsoft.com/ws/2005/05/envelope/none");
            dictionary.Add("http://www.w3.org/2001/XMLSchema-instance");
            dictionary.Add("http://www.w3.org/2001/XMLSchema");
            dictionary.Add("nil");
            dictionary.Add("type");
            dictionary.Add("char");
            dictionary.Add("boolean");
            dictionary.Add("byte");
            dictionary.Add("unsignedByte");
            dictionary.Add("short");
            dictionary.Add("unsignedShort");
            dictionary.Add("int");
            dictionary.Add("unsignedInt");
            dictionary.Add("long");
            dictionary.Add("unsignedLong");
            dictionary.Add("float");
            dictionary.Add("double");
            dictionary.Add("decimal");
            dictionary.Add("dateTime");
            dictionary.Add("string");
            dictionary.Add("base64Binary");
            dictionary.Add("anyType");
            dictionary.Add("duration");
            dictionary.Add("guid");
            dictionary.Add("anyURI");
            dictionary.Add("QName");
            dictionary.Add("time");
            dictionary.Add("date");
            dictionary.Add("hexBinary");
            dictionary.Add("gYearMonth");
            dictionary.Add("gYear");
            dictionary.Add("gMonthDay");
            dictionary.Add("gDay");
            dictionary.Add("gMonth");
            dictionary.Add("integer");
            dictionary.Add("positiveInteger");
            dictionary.Add("negativeInteger");
            dictionary.Add("nonPositiveInteger");
            dictionary.Add("nonNegativeInteger");
            dictionary.Add("normalizedString");
            dictionary.Add("ConnectionLimitReached");
            dictionary.Add("http://schemas.xmlsoap.org/soap/envelope/");
            dictionary.Add("Actor");
            dictionary.Add("Faultcode");
            dictionary.Add("Faultstring");
            dictionary.Add("Faultactor");
            dictionary.Add("Detail");
            return dictionary;
        }
    }
}
