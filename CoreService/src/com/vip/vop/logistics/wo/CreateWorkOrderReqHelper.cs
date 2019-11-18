using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class CreateWorkOrderReqHelper : TBeanSerializer<CreateWorkOrderReq>
	{
		
		public static CreateWorkOrderReqHelper OBJ = new CreateWorkOrderReqHelper();
		
		public static CreateWorkOrderReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateWorkOrderReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier_code(value);
					}
					
					
					
					
					
					if ("logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogistics_no(value);
					}
					
					
					
					
					
					if ("pc3_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPc3_code(value);
					}
					
					
					
					
					
					if ("content".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContent(value);
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
		
		
		public void Write(CreateWorkOrderReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCarrier_code() != null) {
				
				oprot.WriteFieldBegin("carrier_code");
				oprot.WriteString(structs.GetCarrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carrier_code can not be null!");
			}
			
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logistics_no can not be null!");
			}
			
			
			if(structs.GetPc3_code() != null) {
				
				oprot.WriteFieldBegin("pc3_code");
				oprot.WriteString(structs.GetPc3_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pc3_code can not be null!");
			}
			
			
			if(structs.GetContent() != null) {
				
				oprot.WriteFieldBegin("content");
				oprot.WriteString(structs.GetContent());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("content can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateWorkOrderReq bean){
			
			
		}
		
	}
	
}