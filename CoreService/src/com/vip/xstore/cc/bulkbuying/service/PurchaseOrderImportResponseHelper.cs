using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class PurchaseOrderImportResponseHelper : TBeanSerializer<PurchaseOrderImportResponse>
	{
		
		public static PurchaseOrderImportResponseHelper OBJ = new PurchaseOrderImportResponseHelper();
		
		public static PurchaseOrderImportResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrderImportResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("isSuccess".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIsSuccess(value);
					}
					
					
					
					
					
					if ("errorFilePath".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorFilePath(value);
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
		
		
		public void Write(PurchaseOrderImportResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetIsSuccess() != null) {
				
				oprot.WriteFieldBegin("isSuccess");
				oprot.WriteBool((bool)structs.GetIsSuccess());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrorFilePath() != null) {
				
				oprot.WriteFieldBegin("errorFilePath");
				oprot.WriteString(structs.GetErrorFilePath());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrderImportResponse bean){
			
			
		}
		
	}
	
}