using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.inventory{
	
	
	
	public class AdvisedSkuHelper : TBeanSerializer<AdvisedSku>
	{
		
		public static AdvisedSkuHelper OBJ = new AdvisedSkuHelper();
		
		public static AdvisedSkuHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AdvisedSku structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("advise_num".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAdvise_num(value);
					}
					
					
					
					
					
					if ("reservations".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetReservations(value);
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
		
		
		public void Write(AdvisedSku structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAdvise_num() != null) {
				
				oprot.WriteFieldBegin("advise_num");
				oprot.WriteI32((int)structs.GetAdvise_num()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReservations() != null) {
				
				oprot.WriteFieldBegin("reservations");
				oprot.WriteI32((int)structs.GetReservations()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AdvisedSku bean){
			
			
		}
		
	}
	
}