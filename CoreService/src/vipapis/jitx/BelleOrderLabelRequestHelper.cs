using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class BelleOrderLabelRequestHelper : TBeanSerializer<BelleOrderLabelRequest>
	{
		
		public static BelleOrderLabelRequestHelper OBJ = new BelleOrderLabelRequestHelper();
		
		public static BelleOrderLabelRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BelleOrderLabelRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
					}
					
					
					
					
					
					if ("print_details".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.BellePrintDetail> value;
						
						value = new List<vipapis.jitx.BellePrintDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.BellePrintDetail elem1;
								
								elem1 = new vipapis.jitx.BellePrintDetail();
								vipapis.jitx.BellePrintDetailHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPrint_details(value);
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
		
		
		public void Write(BelleOrderLabelRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendor_id can not be null!");
			}
			
			
			if(structs.GetPrint_details() != null) {
				
				oprot.WriteFieldBegin("print_details");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.BellePrintDetail _item0 in structs.GetPrint_details()){
					
					
					vipapis.jitx.BellePrintDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("print_details can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BelleOrderLabelRequest bean){
			
			
		}
		
	}
	
}