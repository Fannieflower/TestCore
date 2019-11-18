using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	public class OutSortingCodeHelper : TBeanSerializer<OutSortingCode>
	{
		
		public static OutSortingCodeHelper OBJ = new OutSortingCodeHelper();
		
		public static OutSortingCodeHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OutSortingCode structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("messageId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMessageId(value);
					}
					
					
					
					
					
					if ("containerCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContainerCode(value);
					}
					
					
					
					
					
					if ("pickCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPickCode(value);
					}
					
					
					
					
					
					if ("carriersCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarriersCode(value);
					}
					
					
					
					
					
					if ("userDefined1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDefined1(value);
					}
					
					
					
					
					
					if ("userDefined2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDefined2(value);
					}
					
					
					
					
					
					if ("userDefined3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDefined3(value);
					}
					
					
					
					
					
					if ("userDefined4".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDefined4(value);
					}
					
					
					
					
					
					if ("userDefined5".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserDefined5(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(OutSortingCode structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMessageId() != null) {
				
				oprot.WriteFieldBegin("messageId");
				oprot.WriteString(structs.GetMessageId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("messageId can not be null!");
			}
			
			
			if(structs.GetContainerCode() != null) {
				
				oprot.WriteFieldBegin("containerCode");
				oprot.WriteString(structs.GetContainerCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("containerCode can not be null!");
			}
			
			
			if(structs.GetPickCode() != null) {
				
				oprot.WriteFieldBegin("pickCode");
				oprot.WriteString(structs.GetPickCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pickCode can not be null!");
			}
			
			
			if(structs.GetCarriersCode() != null) {
				
				oprot.WriteFieldBegin("carriersCode");
				oprot.WriteString(structs.GetCarriersCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carriersCode can not be null!");
			}
			
			
			if(structs.GetUserDefined1() != null) {
				
				oprot.WriteFieldBegin("userDefined1");
				oprot.WriteString(structs.GetUserDefined1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDefined2() != null) {
				
				oprot.WriteFieldBegin("userDefined2");
				oprot.WriteString(structs.GetUserDefined2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDefined3() != null) {
				
				oprot.WriteFieldBegin("userDefined3");
				oprot.WriteString(structs.GetUserDefined3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDefined4() != null) {
				
				oprot.WriteFieldBegin("userDefined4");
				oprot.WriteString(structs.GetUserDefined4());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserDefined5() != null) {
				
				oprot.WriteFieldBegin("userDefined5");
				oprot.WriteString(structs.GetUserDefined5());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OutSortingCode bean){
			
			
		}
		
	}
	
}