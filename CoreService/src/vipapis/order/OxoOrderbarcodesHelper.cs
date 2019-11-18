using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.order{
	
	
	
	public class OxoOrderbarcodesHelper : TBeanSerializer<OxoOrderbarcodes>
	{
		
		public static OxoOrderbarcodesHelper OBJ = new OxoOrderbarcodesHelper();
		
		public static OxoOrderbarcodesHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OxoOrderbarcodes structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("amount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAmount(value);
					}
					
					
					
					
					
					if ("returnApply".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.order.OxoOrderReturnApply> value;
						
						value = new List<vipapis.order.OxoOrderReturnApply>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.order.OxoOrderReturnApply elem0;
								
								elem0 = new vipapis.order.OxoOrderReturnApply();
								vipapis.order.OxoOrderReturnApplyHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetReturnApply(value);
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
		
		
		public void Write(OxoOrderbarcodes structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAmount() != null) {
				
				oprot.WriteFieldBegin("amount");
				oprot.WriteI32((int)structs.GetAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnApply() != null) {
				
				oprot.WriteFieldBegin("returnApply");
				
				oprot.WriteListBegin();
				foreach(vipapis.order.OxoOrderReturnApply _item0 in structs.GetReturnApply()){
					
					
					vipapis.order.OxoOrderReturnApplyHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OxoOrderbarcodes bean){
			
			
		}
		
	}
	
}