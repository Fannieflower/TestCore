using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class RefuseRefundRequestHelper : TBeanSerializer<RefuseRefundRequest>
	{
		
		public static RefuseRefundRequestHelper OBJ = new RefuseRefundRequestHelper();
		
		public static RefuseRefundRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefuseRefundRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("asc_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAsc_sn(value);
					}
					
					
					
					
					
					if ("asc_product_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAsc_product_id(value);
					}
					
					
					
					
					
					if ("opinion".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpinion(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
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
		
		
		public void Write(RefuseRefundRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAsc_sn() != null) {
				
				oprot.WriteFieldBegin("asc_sn");
				oprot.WriteString(structs.GetAsc_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("asc_sn can not be null!");
			}
			
			
			if(structs.GetAsc_product_id() != null) {
				
				oprot.WriteFieldBegin("asc_product_id");
				oprot.WriteString(structs.GetAsc_product_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("asc_product_id can not be null!");
			}
			
			
			if(structs.GetOpinion() != null) {
				
				oprot.WriteFieldBegin("opinion");
				oprot.WriteString(structs.GetOpinion());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("opinion can not be null!");
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefuseRefundRequest bean){
			
			
		}
		
	}
	
}