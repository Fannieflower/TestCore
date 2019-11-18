using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.newretail{
	
	
	
	public class AfterSaleDetailHelper : TBeanSerializer<AfterSaleDetail>
	{
		
		public static AfterSaleDetailHelper OBJ = new AfterSaleDetailHelper();
		
		public static AfterSaleDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AfterSaleDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_id(value);
					}
					
					
					
					
					
					if ("apply_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetApply_id(value);
					}
					
					
					
					
					
					if ("is_return_goods".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIs_return_goods(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreate_time(value);
					}
					
					
					
					
					
					if ("goods_infos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.newretail.GoodsInfo> value;
						
						value = new List<com.vip.vop.cup.api.newretail.GoodsInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.newretail.GoodsInfo elem0;
								
								elem0 = new com.vip.vop.cup.api.newretail.GoodsInfo();
								com.vip.vop.cup.api.newretail.GoodsInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoods_infos(value);
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
		
		
		public void Write(AfterSaleDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApply_id() != null) {
				
				oprot.WriteFieldBegin("apply_id");
				oprot.WriteI64((long)structs.GetApply_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_return_goods() != null) {
				
				oprot.WriteFieldBegin("is_return_goods");
				oprot.WriteByte((byte)structs.GetIs_return_goods()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64((long)structs.GetCreate_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoods_infos() != null) {
				
				oprot.WriteFieldBegin("goods_infos");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.newretail.GoodsInfo _item0 in structs.GetGoods_infos()){
					
					
					com.vip.vop.cup.api.newretail.GoodsInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AfterSaleDetail bean){
			
			
		}
		
	}
	
}